using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata
{
    /// <summary>
    /// An item that can be added to a checkout, and bought.
    /// </summary>
    public class CheckoutItem
    {
        /// <summary>
        /// Constructs and initialises a new instance of CheckoutItem.
        /// </summary>
        /// <param name="price"></param>
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
