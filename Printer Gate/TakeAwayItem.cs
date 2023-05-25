using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrinterGateXP
{
    public class TakeAwayDetails
    {
        public TakeAwayDetails()
        {
            this.name = "";
            this.quantity = "";
            this.price = "";
        }
        public string name = "";
        public string quantity = "";
        public string price = "";
        public float getCost()
        {
            float result = 0;
            string price_str = this.price.Replace("Fr. ", "");
            string quantity_str = this.quantity.Replace("x", "");
            float price = float.Parse(price_str, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            int quantity = 0;
            if (Int32.TryParse(quantity_str, out quantity))
            {
                result = price * quantity;
            }
            return result;
        }
        public string getForamtString()
        {
            return this.name+" "+this.quantity+" "+this.price;
        }


    }
    public class TakeAwayToppingsGroup
    {
        public TakeAwayToppingsGroup()
        {
            this.title = "";
            this.toppings = "";
        }
        public string title;
        public string toppings;
        public string getForamtString()
        {
            return this.title + " " + this.toppings;
        }
    }

    public class TakeAwayTotal
    {
        public TakeAwayTotal()
        {
            this.label = "";
            this.amount = "";
        }
        public string label;
        public string amount;
        public string getForamtString()
        {
            return this.label + " " + this.amount;
        }
    }
    public class TakeAwayItem
    {
        public TakeAwayDetails tk_details = new TakeAwayDetails();
        public List<TakeAwayToppingsGroup> tk_toppings_cont = new List<TakeAwayToppingsGroup>();
        public float getCost()
        {
            return tk_details.getCost();
        }

        public string getDetails()
        {
            return tk_details.getForamtString();
        }

        public string getExtra(int index)
        {
            string result = "";
            if (index < tk_toppings_cont.Count)
                result = tk_toppings_cont[index].getForamtString();
            return result;
        }

    }

    public class TakeAwayItemDetails
    {
        public TakeAwayItemDetails()
        {
            items = new List<TakeAwayItem>();
            total = new TakeAwayTotal();

        }
        public List<TakeAwayItem> items;
        public TakeAwayTotal total;

        public string getTotal()
        {
            return total.getForamtString();
        }
    }
}
