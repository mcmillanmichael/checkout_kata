using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata
{
    public class CheckoutItem
    {
        public CheckoutItem(int price)
        {
            this._price = price;
        }

        /// <summary>
        /// The price of this item.
        /// </summary>
        public decimal Price
        {
            get { return _price; }
        }

        private int _price;
    }
}
