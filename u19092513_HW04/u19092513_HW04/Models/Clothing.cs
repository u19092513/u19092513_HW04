using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19092513_HW04.Models
{
    public class Clothing: Donation
    {
        private int mQuantity;
        private int mCostOfPurchase;

        public int Quantity { get => mQuantity; set => mQuantity = value; }
        public int CostOfPurchase { get => mCostOfPurchase; set => mCostOfPurchase = value; }
        public Clothing()
        {

        }

        public Clothing(string desc, string cond, string date, string details, int quantity, int costofpurchase): base (desc, cond, date, details)
        {
            Quantity = quantity;
            CostOfPurchase = costofpurchase;
        }

        public override double calculateValue()
        {
            double value = 0;
            value = mQuantity * mCostOfPurchase;
            return value;

        }
    }
}