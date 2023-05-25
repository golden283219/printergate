using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;
using PrinterGateXP.Properties;

namespace PrinterGateXP
{
    public partial class MainFormAdvanced : Form
    {
        public event EventHandler FetchJobFinished;


        public event EventHandler FetchJobStarted;

        private AppConfig appConfig
        {
            get
            {
                return AppConfig.appConfig;
            }
        }
        private bool IsSorting = false;
        public bool IsLoading
        {
            get
            {
                return this._bJobRunning;
            }
            set
            {
                this._bJobRunning = value;
            }
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 161;

        private const int HT_CAPTION = 2;

        private List<Order> mOrderList = new List<Order>();

        private Gate gate = Gate.Instance;

        private NotifyIcon notifyIcon;

        private ContextMenu notifyMenu;

        private MenuItem menuItemExit;

        private MenuItem menuItemOpen;

        private BalloonTip balloon;

        private System.Timers.Timer timer = new System.Timers.Timer();
        
        private MediaPlayer player = new MediaPlayer();

        public bool _bJobRunning;

        public DateTime lastPopupTime = DateTime.Now;

        public DateTime lastActivityTime = DateTime.Now;

        private WebBrowser webBrowser;

        TicketTable ticketTableReservation;
        TicketTable ticketTableTakeAway;

        public static bool ticketUITest = false;
        public static bool localServerTest = false;

        public static MainFormAdvanced gMainForm;
        public MainFormAdvanced()
        {
            gMainForm = this;
            InitializeComponent();

            if (ticketUITest) return;
#if DEBUG
            //getTakeAwayItemList(null);
            localServerTest = false;
#endif
            //System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

            this.ticketTableReservation = new TicketTable(this.flowLayoutReservation);
            this.ticketTableTakeAway = new TicketTable(this.flowLayoutTakeAway);
            this.LoadSettings();
            this.btnMaximize.Image = Resources.restore_up;
            this.gate.Host = this.appConfig.host;
            //this.gate.Host = "https://test.waage-flamatt.ch";
            if (localServerTest)
                this.gate.Host = "https://localhost/joomla-site/";
            this.gate.GateInitialized += this.gateInitialized;
            this.FetchJobStarted += this.fetchJobStarted;
            this.FetchJobFinished += this.fetchJobFinished;
            new Thread(new ThreadStart(this.gate.Init)).Start();
            this.setupNotificationIcon();
            this.timer.Elapsed += this.OnTimedEvent;
            this.timer.Interval = 5000.0;
            this.timer.Enabled = true;
            
            this.localizeAll();
            string sss = Localization.Translation("select_menus");//??
            this.balloon = new BalloonTip(this);


        }

        protected override void WndProc(ref Message m)
        {
            bool flag = false;

            if ((long)m.Msg == 132L || (long)m.Msg == 512L)
            {
                Size size = base.Size;
                Point p = new Point(m.LParam.ToInt32());
                Point pt = base.PointToClient(p);
                foreach (KeyValuePair<uint, Rectangle> keyValuePair in new Dictionary<uint, Rectangle>
                {
                    {
                        16U,
                        new Rectangle(0, size.Height - 10, 10, 10)
                    },
                    {
                        15U,
                        new Rectangle(10, size.Height - 10, size.Width - 20, 10)
                    },
                    {
                        17U,
                        new Rectangle(size.Width - 10, size.Height - 10, 10, 10)
                    },
                    {
                        11U,
                        new Rectangle(size.Width - 10, 10, 10, size.Height - 20)
                    },
                    {
                        14U,
                        new Rectangle(size.Width - 10, 0, 10, 10)
                    },
                    {
                        12U,
                        new Rectangle(10, 0, size.Width - 20, 10)
                    },
                    {
                        13U,
                        new Rectangle(0, 0, 10, 10)
                    },
                    {
                        10U,
                        new Rectangle(0, 10, 10, size.Height - 20)
                    }
                })
                {
                    if (keyValuePair.Value.Contains(pt))
                    {
                        m.Result = (IntPtr)((long)((ulong)keyValuePair.Key));
                        flag = true;
                        break;
                    }
                }
            }

            if (!flag)
            {
                base.WndProc(ref m);
            }
        }

        private void LoadSettings()
        {
            AppConfig.LoadSettings();
        }

        private void gateInitialized(object sender, EventArgs e)
        {
            this.fetchJobFinished(null, null);
            this.updateServerStatus();
            this.updatePrinterWarnings();
            if (!this.gate.IsApiInstalled)
            {
                this.showBalloonTip(Localization.Translation("api_not_installed"), Localization.Translation("api_not_installed_details"), ToolTipIcon.Error);
            }
        }

        private void fetchJobStarted(object sender, EventArgs e)
        {
            this.IsLoading = true;
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                this.spinnerLoading.Visible = true;
            }));
        }

        private void fetchJobFinished(object sender, EventArgs e)
        {
            this.IsLoading = false;
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                this.spinnerLoading.Visible = false;
                this.updateServerStatus();
            }));
        }

        private void setupNotificationIcon()
        {
            this.components = new Container();
            this.notifyIcon = new NotifyIcon(this.components);
            this.notifyMenu = new ContextMenu();
            this.menuItemOpen = new MenuItem();
            this.menuItemOpen.Index = 2;
            this.menuItemOpen.Text = "&Open";
            this.menuItemExit = new MenuItem();
            this.menuItemExit.Index = 1;
            this.menuItemExit.Text = "E&xit";
            this.menuItemOpen.Click += this.OnOpen;
            this.menuItemExit.Click += this.OnQuit;
            this.notifyMenu.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItemOpen,
                this.menuItemExit
            });
            this.notifyIcon.Icon = Resources.NotifyIcon;
            this.notifyIcon.ContextMenu = this.notifyMenu;
            this.notifyIcon.Text = "Printer Gate";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += this.OnOpen;
        }

        private void SortOrders()
        {
            Console.WriteLine("SortOrders");
            if (this.IsSorting)
                return;
            this.IsSorting = true;
            List<Order> restaurantList = new List<Order>();
            List<Order> takeAwayList = new List<Order>();
            List<Order> sorted_restaurantList = new List<Order>();
            List<Order> sorted_takeAwayList = new List<Order>();
            foreach (Order order in mOrderList)
            {
                if (order.orderType == OrderType.Table)
                    restaurantList.Add(order);
                else if (order.orderType == OrderType.Food)
                    takeAwayList.Add(order);
            }

            List<Order> confirmed_list = new List<Order>();
            List<Order> pending_list = new List<Order>();
            
            foreach (Order order in restaurantList)
            {
                if (order.status == OrderStatus.Confirmed)
                    confirmed_list.Add(order);
                if (order.status == OrderStatus.Pending)
                    pending_list.Add(order);
            }
            confirmed_list.Sort((x, y) => Utils.UnixTimeStampToDateTime(x.date_checkin).CompareTo(Utils.UnixTimeStampToDateTime(y.date_checkin)));
            pending_list.Sort((x, y) => Utils.UnixTimeStampToDateTime(x.date).CompareTo(Utils.UnixTimeStampToDateTime(y.date)));
            sorted_restaurantList.AddRange(confirmed_list);
            sorted_restaurantList.AddRange(pending_list);

            confirmed_list.Clear();
            pending_list.Clear();
            foreach (Order order in takeAwayList)
            {
                if (order.status == OrderStatus.Confirmed)
                    confirmed_list.Add(order);
                if (order.status == OrderStatus.Pending)
                    pending_list.Add(order);
            }
            confirmed_list.Sort((x, y) => Utils.UnixTimeStampToDateTime(x.date_checkin).CompareTo(Utils.UnixTimeStampToDateTime(y.date_checkin)));
            pending_list.Sort((x, y) => Utils.UnixTimeStampToDateTime(x.date).CompareTo(Utils.UnixTimeStampToDateTime(y.date)));
            sorted_takeAwayList.AddRange(confirmed_list);
            sorted_takeAwayList.AddRange(pending_list);

            this.ticketTableReservation.SetOrderList(sorted_restaurantList);
            this.ticketTableTakeAway.SetOrderList(sorted_takeAwayList);

            this.IsSorting = false;
        }
        private Thread mRefreshOrderThread = null;
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("****OnTimedEvent****");
            if (this.IsLoading || this.IsSorting)
            {
                return;
            }
            //new Thread(new ThreadStart(this.RefreshOrders)).Start();
            mRefreshOrderThread = new Thread(new ThreadStart(this.RefreshOrders));
            mRefreshOrderThread.Start();
            
            if (this.mOrderList.Find((Order order) => order.status == OrderStatus.Pending) == null)
            {
                if ((DateTime.Now - this.lastActivityTime).TotalSeconds >= (double)this.appConfig.closePopupAfter && base.Visible)
                {
                    base.BeginInvoke(new MethodInvoker(delegate ()
                    {
                    }));
                    this.lastActivityTime = DateTime.Now;
                }
                return;
            }
            if ((DateTime.Now - this.lastPopupTime).TotalSeconds >= (double)this.appConfig.reOpenPopupAfter && this.gate.IsOnline)
            {
                base.BeginInvoke(new MethodInvoker(delegate ()
                {
                    base.Show();
                    this.showBalloonTip(Localization.Translation("orders"), Localization.Translation("unprocessed_orders"), ToolTipIcon.Info);
                }));
                this.resetLastPopupTime();
            }
        }

        private void localizeAll()
        {
            this.Text = Localization.Translation("app_name");
            this.labelTitle.Text = "Printer Gate";//"Printer Gate 3.0.8";//this.Text;
            this.labelReservations.Text = Localization.Translation("reservations");
            this.labelTakeAway.Text = Localization.Translation("take_away");
            this.buttonBigClose.Text = Localization.Translation("close");
            this.ticketTableReservation.Localize();//??this.ordersTableReservation.Localize(); 
            this.ticketTableTakeAway.Localize();//??this.ordersTableTakeAway.Localize();    
        }

        private void updateServerStatus()
        {
            this.labelServerStatus.BackColor = (this.gate.IsOnline ? AppColor.GREEN : AppColor.DANGER);
            if (!this.gate.IsOnline && this.appConfig.alarmLostConnectionEnabled && (DateTime.Now - this.lastPopupTime).TotalSeconds >= (double)this.appConfig.reOpenPopupAfter)
            {
                this.showBalloonTip(Localization.Translation("connection_lost"), Localization.Translation("no_internet_connection"), ToolTipIcon.Error);
                this.playAlarmSound(AlarmType.ConnectionLost);
                this.resetLastPopupTime();
            }
        }

        private void updatePrinterWarnings()
        {
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                this.labelReservationPrinterWarning.Text = Localization.Translation("reservation_printer_warning");
                this.labelTakeAwayPrinterWarning.Text = Localization.Translation("take_away_printer_warning");
                List<GatePrinter> gatePrinters = this.appConfig.gatePrinters;
                this.labelReservationPrinterWarning.Visible = (gatePrinters[0].printerName == "");
                this.labelTakeAwayPrinterWarning.Visible = !this.isTakeAwayPrintersAvailable();
            }));
        }

        private void showBalloonTip(string title, string content, ToolTipIcon icon = ToolTipIcon.Info)
        {
            int timeout = this.appConfig.closePopupAfter * 1000;
            this.notifyIcon.BalloonTipTitle = title;
            this.notifyIcon.BalloonTipText = content;
            this.notifyIcon.BalloonTipIcon = icon;
            this.notifyIcon.ShowBalloonTip(timeout);
            this.notifyIcon.BalloonTipClicked += delegate (object sender, EventArgs args)
            {
                base.Show();
                base.Activate();
            };
        }


        private void OnOpen(object sender, EventArgs args)
        {
            base.Show();
        }

        private void OnQuit(object sender, EventArgs args)
        {
            if (MessageBox.Show(Localization.Translation("quit_text"), Localization.Translation("confirmation"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (mRefreshOrderThread != null)
                    mRefreshOrderThread.Abort();
                Application.Exit();
            }
        }
       
        private void RefreshOrders()
        {
            Console.WriteLine("RefreshOrders");
            //fixed the error that occurs on exit the app.
            if (!IsHandleCreated) return;
            EventHandler fetchJobStarted = this.FetchJobStarted;
            if (fetchJobStarted != null)
            {
                fetchJobStarted(null, null);
            }
            this.reloadOrderList();
            //print incoming orders
            this.printIncomingOrders();//this.printConfirmedOrders();
            EventHandler fetchJobFinished = this.FetchJobFinished;
            if (fetchJobFinished == null)
            {
                return;
            }
            fetchJobFinished(null, null);
        }


        private void resetLastPopupTime()
        {
            this.lastPopupTime = DateTime.Now;
        }

        private string defaultAlarmPath(int index)
        {
            return string.Format("alarm/Alarm{0:00}.mp3", index + 1);
        }

        private void playAlarmSound(AlarmType alarmType)
        {
            int volume = 0;
            string path = "";
            switch (alarmType)
            {
                case AlarmType.ConnectionLost:
                    volume = this.appConfig.lostConnectionAlarmVolume;
                    path = ((this.appConfig.lostConnectionAlarmIndex == AppConfig.DEFAULT_ALARM_COUNT) ? this.appConfig.lostConnectionAlarmPath : this.defaultAlarmPath(this.appConfig.lostConnectionAlarmIndex));
                    break;
                case AlarmType.TableReservation:
                    volume = this.appConfig.tableReservationAlarmVolume;
                    path = ((this.appConfig.tableReservationAlarmIndex == AppConfig.DEFAULT_ALARM_COUNT) ? this.appConfig.tableReservationAlarmPath : this.defaultAlarmPath(this.appConfig.tableReservationAlarmIndex));
                    break;
                case AlarmType.TakeAway:
                    volume = this.appConfig.foodReservationAlarmVolume;
                    path = ((this.appConfig.foodReservationAlarmIndex == AppConfig.DEFAULT_ALARM_COUNT) ? this.appConfig.foodReservationAlarmPath : this.defaultAlarmPath(this.appConfig.foodReservationAlarmIndex));
                    break;
                case AlarmType.HotelReservation:
                    volume = this.appConfig.hotelReservationAlarmVolume;
                    path = ((this.appConfig.hotelReservationAlarmIndex == AppConfig.DEFAULT_ALARM_COUNT) ? this.appConfig.hotelReservationAlarmPath : this.defaultAlarmPath(this.appConfig.hotelReservationAlarmIndex));
                    break;
            }
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                this.player.Open(new Uri(Path.GetFullPath(path)));
                this.player.Volume = (double)((float)volume / 100f);
                this.player.Play();
            }));
        }

        private bool isTakeAwayPrintersAvailable()
        {
            if (this.gate.tkMenus.Count == 0)
            {
                return false;
            }
            if (this.appConfig.FindRemainingMenus().Count != 0)
            {
                return false;
            }
            List<GatePrinter> list = this.appConfig.gatePrinters;
            list = list.GetRange(2, list.Count - 2);
            return list.Find((GatePrinter printer) => printer.printerName == "") == null;
        }

        private void exportOrderToXml(Order order)
        {
            if (this.appConfig.exportToXMLEnabled == false)
                return;
            string xmlFilePath = this.appConfig.exportToXMLPath;
            XDocument doc;
            if (File.Exists(xmlFilePath))
                doc = XDocument.Load(xmlFilePath);
            else
            {
                doc = new XDocument();
                doc.Add(new XElement("Orders"));
            }
            foreach (XElement node in doc.Element("Orders").Elements())
            {
                if (node.Attribute("Type").Value == order.orderType.ToString() &&
                    node.Attribute("No").Value == order.id)
                    return;
            }
            XElement element = new XElement("Order");
            element.Add(new XAttribute("Type", order.orderType));
            element.Add(new XAttribute("No", order.id));
            element.Add(new XElement("DateTime", Utils.UnixTimeStampToDateTime(order.date_checkin).ToString("dd.MM.yyyy H:mm")));
            element.Add(new XElement("Name", order.name));
            element.Add(new XElement("Phone", order.phone));
            element.Add(new XElement("Email", order.email));
            doc.Element("Orders").Add(element);
            doc.Save(xmlFilePath);
        }

        private double sort_time = 0;
        private void reloadOrderList()
        {
            sort_time += this.timer.Interval;
            if(sort_time >= 1 * 60 * 1000)
            {
                Console.WriteLine("Sorting list");
                sort_time = 0;
                this.BeginInvoke(new MethodInvoker(delegate ()
                {
                    this.SortOrders();
                }));
                return;
            }

            Console.WriteLine("Reloading list");
            foreach (Order queryOrder in this.gate.QueryOrders())
            {
                Order order = queryOrder;
                bool isPast30Min = Utils.isOrderPast30Min(order);
                int iFound = this.findOrderIndex(order.id, order.orderType);
                if (iFound == -1)
                {
                    exportOrderToXml(order);
                    this.autoConfirmOrder(order);
                    this.BeginInvoke(new MethodInvoker(delegate ()
                    {
                        this.addOrderToListView(this.mOrderList.Count, order);
                        this.mOrderList.Add(order);
                        if (order.status == OrderStatus.Pending)
                            this.alarmNewOrder(order);
                    }));
                }
                else
                {
                    if (isPast30Min)
                    {
                        this.BeginInvoke(new MethodInvoker(delegate ()
                        {

                            this.removeOrderFromListView(this.mOrderList.Count, order);
                            this.mOrderList.Remove(order);
                        }));
                    }
                    else
                    {
                        Order mOrder = this.mOrderList[iFound];
                        if (mOrder.status != order.status && mOrder.status == OrderStatus.Pending)
                        {
                            mOrder.status = order.status;
                            this.BeginInvoke(new MethodInvoker(delegate ()
                            {
                                this.updateOrderStatus(iFound, order.status);
                            }));
                        }
                    }
                }
            }
        }
        /*
        private void printConfirmedOrders()
        {
            //This code isn’t thread-safe
            //??foreach (Order order in this.mOrderList)
            var items = mOrderList.ToArray();
            foreach (Order order in items)
            {
                if ((order.status == OrderStatus.Pending && order.printStatus == PrintStatus.Pending) || 
                    (order.status == OrderStatus.Confirmed && (order.printStatus == PrintStatus.PrintedBrief || 
                    order.printStatus == PrintStatus.Pending)))
                {
                    this.printOrder(order);
                }
            }
        }
        */

        private void printIncomingOrders()
        {
            //This code isn’t thread-safe
            //??foreach (Order order in this.mOrderList)
            var items = mOrderList.ToArray();
            foreach (Order order in items)
            {
                if (order.status == OrderStatus.Pending && order.printStatus == PrintStatus.Pending)
                {

                    if (order.orderType == OrderType.Food && this.appConfig.printTKAnyway)
                        printOrder(order, false);
                    if (order.orderType == OrderType.Table && this.appConfig.printReservationAnyway)
                        printOrder(order, false);
                }
            }
        }

        private int findOrderIndex(string id, OrderType type)
        {
            int count = this.mOrderList.Count;
            for (int i = 0; i < count; i++)
            {
                if (this.mOrderList[i].id == id && this.mOrderList[i].orderType == type)
                {
                    return i;
                }
            }
            return -1;
        }

        private void autoConfirmOrder(Order order)
        {
            Thread.Sleep(500);
            if (order.status != OrderStatus.Pending)
            {
                return;
            }
            if ((order.orderType == OrderType.Food && this.appConfig.autoConfimTakeAway) ||
                (order.orderType == OrderType.Table && this.appConfig.autoConfirmReservation))
            {
                order.status = (this.gate.ChangeOrderState(order.id, order.orderType, Gate.ACTION_CONFIRM) ? OrderStatus.Confirmed : order.status);
                if(order.status == OrderStatus.Confirmed)
                {
                    if (order.orderType == OrderType.Food && this.appConfig.printTKAnyway)
                        printOrder(order, false);
                    if (order.orderType == OrderType.Table && this.appConfig.printReservationAnyway)
                        printOrder(order, this.appConfig.printReservationWithBeautyWhenConfirmed);
                }
            }
        }

        
        private void addOrderToListView(int index, Order order)
        {
            OrderType orderType = order.orderType;
            if (orderType == OrderType.Table || orderType == OrderType.Food)
            {

                if (orderType == OrderType.Table)
                {
                    this.ticketTableReservation.AddOrder(order); //this.ordersTableReservation.AddOrder(order);//??

                }
                else if (orderType == OrderType.Food)
                {
                   this.ticketTableTakeAway.AddOrder(order); //this.ordersTableTakeAway.AddOrder(order);//??    
                }
            }

        }

        private void removeOrderFromListView(int index, Order order)
        {
            OrderType orderType = order.orderType;
            if (orderType == OrderType.Table || orderType == OrderType.Food)
            {

                if (orderType == OrderType.Table)
                {
                    this.ticketTableReservation.RemoveOrder(order); //this.ordersTableReservation.AddOrder(order);//??

                }
                else if (orderType == OrderType.Food)
                {
                    this.ticketTableTakeAway.RemoveOrder(order); //this.ordersTableTakeAway.AddOrder(order);//??    
                }
            }

        }


        private void alarmNewOrder(Order order)
        {
            switch (order.orderType)
            {
                case OrderType.Table:
                    if (this.appConfig.tableReservationPopupEnabled)
                    {
                        base.Show();
                    }
                    this.showBalloonTip("New Table Reservation", order.name + " wants to reserve a table.", ToolTipIcon.Info);
                    if (this.appConfig.tableReservationAlarmEnabled)
                    {
                        this.playAlarmSound(AlarmType.TableReservation);
                        return;
                    }
                    break;
                case OrderType.Food:
                    if (this.appConfig.foodReservationPopupEnabled)
                    {
                        base.Show();
                    }
                    this.showBalloonTip("New Take Away", order.name + " wants to order some food.", ToolTipIcon.Info);
                    if (this.appConfig.foodReservationAlarmEnabled)
                    {
                        this.playAlarmSound(AlarmType.TakeAway);
                        return;
                    }
                    break;
                case OrderType.Room:
                    if (this.appConfig.hotelReservationPopupEnabled)
                    {
                        base.Show();
                    }
                    this.showBalloonTip("New Room Reservation", order.name + " wants to reserve a room.", ToolTipIcon.Info);
                    if (this.appConfig.hotelReservationAlarmEnabled)
                    {
                        this.playAlarmSound(AlarmType.HotelReservation);
                    }
                    break;
                default:
                    return;
            }
        }

        private void updateOrderStatus(int index, OrderStatus status)
        {
            Order order = this.mOrderList[index];
            OrderType orderType = order.orderType;
            if (orderType == OrderType.Table)
            {
                //??this.ordersTableReservation.UpdateOrderStatus(order.id, status);
                this.ticketTableReservation.UpdateOrderStatus(order.id, status);
            }
            else if (orderType == OrderType.Food)
            {
                this.ticketTableTakeAway.UpdateOrderStatus(order.id, status);
                //??this.ordersTableTakeAway.UpdateOrderStatus(order.id, status);
            }

        }


        private bool printHtml(string html, string printerName, bool showPrintDialog, bool bBeautiful = false)
        {
            string strExeFilePath = "";
            if (!showPrintDialog && printerName.Length == 0)
            {
                return false;
            }
            
            strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            strExeFilePath = System.IO.Path.GetDirectoryName(strExeFilePath) + "\\PrintHtml.exe";
            if (!File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\PrintHtml.exe"))
                return false;
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                using (Process process = new Process())
                {
                    string tempFileName = Path.GetTempFileName();
                    File.WriteAllText(tempFileName, html);
                    process.StartInfo.FileName = "PrintHtml.exe";
                    int num = bBeautiful ? 1 : 0;
                    process.StartInfo.Arguments = string.Format("-p \"{0}\" -l {1} -t {2} -r {3} -b {4} \"{5}\"", new object[]
                    {
                        printerName,
                        num,
                        num,
                        num,
                        num,
                        tempFileName
                    });
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                }
            }));

            return true;
        }

        public void printOrder(Order order, Boolean asBeauty)
        {
            Console.WriteLine("Print order: " + order.id);
            OrderType orderType = order.orderType;

            if (orderType == OrderType.Food)
            {
                if (!this.isTakeAwayPrintersAvailable())
                {
                    return;
                }

                List<string> list = Gate.Instance.ListTakeAwayOrderFoodCategories(order.id);
                List<GatePrinter> gatePrinters = this.appConfig.gatePrinters;
                bool flag = true;
                List<string[]> list2 = new List<string[]>();
                foreach (GatePrinter gatePrinter in this.appConfig.gatePrinters)
                {
                    if (gatePrinter.tkMenuIds.Count != 0 && ArrayUtils.FindIntersection(list, gatePrinter.tkMenuIds))
                    {
                        string text = this.gate.ReservationHtml(order.orderType, order.id, gatePrinter.tkMenuIds);
                        if (text == "")
                        {
                            break;
                        }
                        foreach (string item in gatePrinter.tkMenuIds)
                        {
                            list.Remove(item);
                        }
                        list2.Add(new string[]
                        {
                                    text,
                                    gatePrinter.printerName
                        });
                    }
                }
                foreach (string[] array in list2)
                {
                    if (!this.printHtml(array[0], array[1], this.appConfig.showPrinterDialog, asBeauty))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    bool flag2 = list.Count == 0;
                }
                if (flag)
                {
                    order.printStatus = PrintStatus.Printed;
                }


            }

            else if (orderType == OrderType.Table)
            {
                string text2 = this.gate.ReservationHtml(order.orderType, order.id, null);
                if (!(text2 == ""))
                {
                    GatePrinter tablePrinter = this.appConfig.gatePrinters[0];
                    GatePrinter beautyPrinter = this.appConfig.gatePrinters[1];
                    GatePrinter printer = (order.status == OrderStatus.Confirmed) ? beautyPrinter : tablePrinter;
                    if (printer.printerName == "")
                    {
                        return;
                    }
                    this.printHtml(text2, printer.printerName, this.appConfig.showPrinterDialog, asBeauty);
                    //order.printStatus = ((order.status == OrderStatus.Pending) ? PrintStatus.PrintedBrief : PrintStatus.Printed);
                    order.printStatus = PrintStatus.Printed;
                }
            }
            this.updatePrintStatus(order.id, order.printStatus);
        }

        private void updatePrintStatus(string orderId, PrintStatus status)
        {
            int index = this.mOrderList.FindIndex((Order order) => order.id == orderId);
            Order selectedOrder = this.mOrderList[index];
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                OrderType orderType = selectedOrder.orderType;
                if (orderType == OrderType.Table)
                {
                    //??this.ordersTableReservation.UpdateOrderPrintStatus(selectedOrder.id, status);
                    this.ticketTableReservation.UpdateOrderPrintStatus(selectedOrder.id, status);
                }
                else if (orderType == OrderType.Food)
                {
                    //??this.ordersTableTakeAway.UpdateOrderPrintStatus(selectedOrder.id, status);
                    this.ticketTableTakeAway.UpdateOrderPrintStatus(selectedOrder.id, status); ;
                }

            }));
        }


        //Event Handlers

        private void OnHideToTray(object sender, EventArgs e)
        {
            base.Hide();
            if (this.appConfig.showBalloon)
            {
                this.balloon.Show();
            }
        }

        private void flowLayoutTitleBarSpacer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainFormAdvanced.ReleaseCapture();
                MainFormAdvanced.SendMessage(base.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            this.localizeAll();
        }

        private void OnMaximize(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Maximized)
            {
                this.btnMaximize.Image = Resources.maximize_up;
                base.WindowState = FormWindowState.Normal;
                return;
            }
            this.btnMaximize.Image = Resources.restore_up;
            base.WindowState = FormWindowState.Maximized;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.weratv.ch");
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            SortOrders();
        }
    }
}
