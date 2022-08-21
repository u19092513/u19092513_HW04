using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19092513_HW04.Models
{
    public class Donation
    {
        public string Description { get; set; }
        public string Condition { get; set; }
        public string Date { get; set; }
        public string Details { get; set; }
        
        
        public Donation()
        {

        }

        public Donation (string description, string condition, string date, string details)
        {
            Description = description;
            Condition = condition;
            Date = date;
            Details = details;
            
        }

        public virtual double calculateValue()
        {
            return 0;
        }
    }
}