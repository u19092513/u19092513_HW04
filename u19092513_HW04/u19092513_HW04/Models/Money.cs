using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19092513_HW04.Models
{
    public class Money: Donation
    {
        private int mTotal;


        public int Total { get => mTotal; set => mTotal = value; }
        public Money()
        {

        }

        public Money(string desc, string cond, string date, string details, int total) : base(desc, cond, date, details)
        {
            Total = total;

        }

        public override double calculateValue()
        {
            double value = 0;
            value = mTotal;
            return value;

        }
    }
}