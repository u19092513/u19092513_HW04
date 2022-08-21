using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19092513_HW04.Models
{
    public class Food: Donation
    {
        private int mWeight;
        private int mNumber;
        

        public int Weight{ get => mWeight; set => mWeight = value; }
        public int Number { get => mNumber; set => mNumber= value; }


        public Food()
        {

        }

        public Food(string desc, string cond, string date, string details, int weight, int number) : base(desc, cond, date, details)
        {
            Weight = weight;
            Number = number;
            
        }

        public override double calculateValue()
        {
            double value = 0;
            value = mWeight * mNumber;
            return value;

        }
    }
}