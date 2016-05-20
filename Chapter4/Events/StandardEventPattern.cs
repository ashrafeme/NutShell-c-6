using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Events {

    public delegate void PriceChangedEventHandler(object sender, PriceChangedEventArgs e);
    class StandardEventPattern {

        public static void PriceChangedTest() {

            Stock stock = new Stock("THPW");
            stock.Price = 27.10M;
            // Register with the PriceChanged event
            stock.PriceChanged += Stock_PriceChanged2;
            stock.PriceChanged += stock_PriceChanged;
            
            stock.Price = 31.59M;
        }

        private static void Stock_PriceChanged2(object sender, PriceChangedEventArgs e) {
           // throw new NotImplementedException();
        }

        private static void stock_PriceChanged(object sender, PriceChangedEventArgs e) {
            if ((e.newPrice - e.lastPrice) / e.lastPrice > 0.1M)
                Console.WriteLine("Alert, 10% stock price increase!");
        }
    }

    public class PriceChangedEventArgs : EventArgs {

        public readonly decimal lastPrice;
        public readonly decimal newPrice;

        public PriceChangedEventArgs(decimal lastPrice,decimal newPrice) {
            this.lastPrice = lastPrice;
            this.newPrice = newPrice;
        }

    }


}
