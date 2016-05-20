using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Preporties
{
   public class Stock
    {
        private decimal currentPrice;

        public decimal CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        decimal  sharesOwned;
        public decimal Worth
        {
            get { return currentPrice * sharesOwned; }
        }

        public decimal Worth2 => currentPrice * sharesOwned;

        public decimal CurrentPrice2 { get; set; } = 132;

        public int Maximum { get; } = 999;

        private decimal x;

        public decimal X
        {
            get { return x; }
           private set { x = Math.Round(value,2); }
        }


    }
}
