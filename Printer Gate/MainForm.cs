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
using PrinterGateXP.Properties;

namespace PrinterGateXP
{
	public partial class MainForm : Form
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

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		public MainForm()
		{
			this.InitializeComponent();
			this.LoadSettings();
			this.btnMaximize.Image = Resources.restore_up;
			this.gate.Host = this.appConfig.host;
			this.gate.GateInitialized += this.gateInitialized;
			this.FetchJobStarted += this.fetchJobStarted;
			this.FetchJobFinished += this.fetchJobFinished;
			new Thread(new ThreadStart(this.gate.Init)).Start();
			this.setupNotificationIcon();
			this.timer.Elapsed += this.OnTimedEvent;
			this.timer.Interval = 5000.0;
			this.timer.Enabled = true;
			this.localizeAll();
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

		private void updatePrinterWarnings()
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.labelReservationPrinterWarning.Text = Localization.Translation("reservation_printer_warning");
				this.labelTakeAwayPrinterWarning.Text = Localization.Translation("take_away_printer_warning");
				List<GatePrinter> gatePrinters = this.appConfig.gatePrinters;
				this.labelReservationPrinterWarning.Visible = (gatePrinters[0].printerName == "");
				this.labelTakeAwayPrinterWarning.Visible = !this.isTakeAwayPrintersAvailable();
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

		private void localizeAll()
		{
			this.Text = Localization.Translation("app_name");
			this.labelTitle.Text = this.Text+"+debug"; //??
			this.labelReservations.Text = Localization.Translation("reservations");
			this.labelTakeAway.Text = Localization.Translation("take_away");
			this.buttonBigClose.Text = Localization.Translation("close");
			this.ordersTableReservation.Localize();
			this.ordersTableTakeAway.Localize();
		}

		private Thread mRefreshOrderThread = null;
		private void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			if (this.IsLoading)
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
					base.BeginInvoke(new MethodInvoker(delegate()
					{
					}));
					this.lastActivityTime = DateTime.Now;
				}
				return;
			}
			if ((DateTime.Now - this.lastPopupTime).TotalSeconds >= (double)this.appConfig.reOpenPopupAfter && this.gate.IsOnline)
			{
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					base.Show();
					this.showBalloonTip(Localization.Translation("orders"), Localization.Translation("unprocessed_orders"), ToolTipIcon.Info);
				}));
				this.resetLastPopupTime();
			}
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

		private void LoadSettings()
		{
			AppConfig.LoadSettings();
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

		private void addOrderToListView(int index, Order order)
		{
			OrderType orderType = order.orderType;
			if (orderType == OrderType.Table)
			{
				this.ordersTableReservation.AddOrder(order);
				return;
			}
			if (orderType != OrderType.Food)
			{
				return;
			}
			this.ordersTableTakeAway.AddOrder(order);
		}

		private void updateOrderStatus(int index, OrderStatus status)
		{
			Order order = this.mOrderList[index];
			OrderType orderType = order.orderType;
			if (orderType == OrderType.Table)
			{
				this.ordersTableReservation.UpdateOrderStatus(order.id, status);
				return;
			}
			if (orderType != OrderType.Food)
			{
				return;
			}
			this.ordersTableTakeAway.UpdateOrderStatus(order.id, status);
		}

		private void updatePrintStatus(string orderId, PrintStatus status)
		{
			int index = this.mOrderList.FindIndex((Order order) => order.id == orderId);
			Order selectedOrder = this.mOrderList[index];
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				OrderType orderType = selectedOrder.orderType;
				if (orderType == OrderType.Table)
				{
					this.ordersTableReservation.UpdateOrderPrintStatus(selectedOrder.id, status);
					return;
				}
				if (orderType != OrderType.Food)
				{
					return;
				}
				this.ordersTableTakeAway.UpdateOrderPrintStatus(selectedOrder.id, status);
			}));
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			new SettingsForm().ShowDialog();
			this.localizeAll();
		}

		private void btnChangeLanguage_Click(object sender, EventArgs e)
		{
			Localization.ToggleLanguage();
			this.localizeAll();
		}

		private void flowLayoutTitleBarSpacer_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				MainForm.ReleaseCapture();
				MainForm.SendMessage(base.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
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
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.spinnerLoading.Visible = true;
			}));
		}

		private void fetchJobFinished(object sender, EventArgs e)
		{
			this.IsLoading = false;
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.spinnerLoading.Visible = false;
				this.updateServerStatus();
			}));
		}

		private void OnOpen(object sender, EventArgs args)
		{
			base.Show();
		}

		private void OnHideToTray(object sender, EventArgs args)
		{
			base.Hide();
			if (this.appConfig.showBalloon)
			{
				this.balloon.Show();
			}
		}

		private void OnMaximize(object sender, EventArgs args)
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

		private void OnQuit(object sender, EventArgs args)
		{
			if (MessageBox.Show(Localization.Translation("quit_text"), Localization.Translation("confirmation"), MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				if (mRefreshOrderThread != null)
					mRefreshOrderThread.Abort();
				Application.Exit();
			}
		}

		private void showBalloonTip(string title, string content, ToolTipIcon icon = ToolTipIcon.Info)
		{
			int timeout = this.appConfig.closePopupAfter * 1000;
			this.notifyIcon.BalloonTipTitle = title;
			this.notifyIcon.BalloonTipText = content;
			this.notifyIcon.BalloonTipIcon = icon;
			this.notifyIcon.ShowBalloonTip(timeout);
			this.notifyIcon.BalloonTipClicked += delegate(object sender, EventArgs args)
			{
				base.Show();
				base.Activate();
			};
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
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.player.Open(new Uri(Path.GetFullPath(path)));
				this.player.Volume = (double)((float)volume / 100f);
				this.player.Play();
			}));
		}

		
		private void pictureBoxLogo_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.weratv.ch");
		}

		
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

		private void reloadOrderList()
		{
			foreach (Order queryOrder in this.gate.QueryOrders())
			{
				Order order = queryOrder;
				int iFound = this.findOrderIndex(order.id, order.orderType);
				if (iFound == -1)
				{
					this.autoConfirmOrder(order);
					this.BeginInvoke(new MethodInvoker(delegate ()
					{
						this.addOrderToListView(this.mOrderList.Count, order);
						this.mOrderList.Add(order);
						this.alarmNewOrder(order);
					}));
				}
				else
				{
					Order mOrder = this.mOrderList[iFound];
					if (mOrder.status != order.status && mOrder.status == OrderStatus.Pending)
					{
						mOrder.status = order.status;
						this.BeginInvoke(new MethodInvoker(delegate () {
							this.updateOrderStatus(iFound, order.status);
						}));
					}
				}
			}
		}

		
		private void autoConfirmOrder(Order order)
		{
			Thread.Sleep(500);
			if (order.status != OrderStatus.Pending)
			{
				return;
			}
			if ((order.orderType == OrderType.Food && this.appConfig.autoConfimTakeAway) || (order.orderType == OrderType.Table && this.appConfig.autoConfirmReservation))
			{
				order.status = (this.gate.ChangeOrderState(order.id, order.orderType, Gate.ACTION_CONFIRM) ? OrderStatus.Confirmed : order.status);
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

		
		private void resetLastPopupTime()
		{
			this.lastPopupTime = DateTime.Now;
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

		
		private void printConfirmedOrders()
		{
			//This code isn’t thread-safe
			//??foreach (Order order in this.mOrderList)
			var items = mOrderList.ToArray();
			foreach (Order order in items)
			{
				if ((order.status == OrderStatus.Pending && order.printStatus == PrintStatus.Pending) || (order.status == OrderStatus.Confirmed && (order.printStatus == PrintStatus.PrintedBrief || order.printStatus == PrintStatus.Pending)))
				{
					this.printOrder(order);
				}
			}
		}

		
		private bool printHtml(string html, string printerName, bool showPrintDialog, bool bBeautiful = false)
		{
			if (!showPrintDialog && printerName.Length == 0)
			{
				return false;
			}
			base.BeginInvoke(new MethodInvoker(delegate()
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

		
		private void printOrder(Order order)
		{
			OrderType orderType = order.orderType;
			if (orderType != OrderType.Table)
			{
				if (orderType == OrderType.Food)
				{
					if (!this.isTakeAwayPrintersAvailable())
					{
						return;
					}
					if (order.status == OrderStatus.Pending || (order.status == OrderStatus.Confirmed && this.appConfig.autoConfimTakeAway && this.appConfig.printTKAnyway))
					{
						List<string> list = Gate.Instance.ListTakeAwayOrderFoodCategories(order.id);
						List<GatePrinter> gatePrinters = this.appConfig.gatePrinters;
						bool flag = true;
						List<string[]> list2 = new List<string[]>();
						foreach (GatePrinter gatePrinter in gatePrinters)
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
							if (!this.printHtml(array[0], array[1], this.appConfig.showPrinterDialog, false))
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
					else
					{
						OrderStatus status = order.status;
					}
				}
			}
			else
			{
				string text2 = this.gate.ReservationHtml(order.orderType, order.id, null);
				if (!(text2 == ""))
				{
					GatePrinter gatePrinter2 = this.appConfig.gatePrinters[0];
					GatePrinter gatePrinter3 = this.appConfig.gatePrinters[1];
					GatePrinter gatePrinter4 = (order.status == OrderStatus.Pending) ? gatePrinter2 : gatePrinter3;
					if (gatePrinter3.printerName == "")
					{
						gatePrinter4 = gatePrinter2;
					}
					this.printHtml(text2, gatePrinter4.printerName, this.appConfig.showPrinterDialog, order.status == OrderStatus.Confirmed);
					order.printStatus = ((order.status == OrderStatus.Pending) ? PrintStatus.PrintedBrief : PrintStatus.Printed);
				}
			}
			this.updatePrintStatus(order.id, order.printStatus);
		}

		
		private void RefreshOrders()
		{
			//fixed the error that occurs on exit the app.
			if (!IsHandleCreated) return;
			EventHandler fetchJobStarted = this.FetchJobStarted;
			if (fetchJobStarted != null)
			{
				fetchJobStarted(null, null);
			}
			this.reloadOrderList();
			this.printConfirmedOrders();
			EventHandler fetchJobFinished = this.FetchJobFinished;
			if (fetchJobFinished == null)
			{
				return;
			}
			fetchJobFinished(null, null);
		}

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
	}
}
