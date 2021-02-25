using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlvinaServis
{
    partial class Service
    {
        public int GetDurationInSeconds
        {
            get
            {
                return DurationInSeconds= DurationInSeconds / 60;
            }
        }
        public decimal GetCost
        {
            get
            {
                return Math.Round(Cost,0);
            }
        }
        public double GetDiscount
        {
            get
            {
                double dis = Convert.ToDouble(Discount/100);
                double cost = Convert.ToDouble(GetCost);
                double d =  cost+cost*dis;
                return d;
            }
        }
        public string ColorDiscount
        {
           
            get
            {
                string color="";
                if (this.Discount != 0) color = "Green";
                return color;
            }
        }
        public string MainImage
        {
            get
            {
                return ( @"/" + this.MainImagePath);
            }
        }
    }
}
