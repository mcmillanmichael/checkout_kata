using System;
using System.Collections.Generic;

namespace checkout_kata
{
    /// <summary>
    /// A checkout system.
    /// </summary>
    public class Checkout
    {
        public List<CheckoutItem> Items { get; private set; }

        public Checkout()
        {
            Items = new List<CheckoutItem>();
        }

        public void AddItem(CheckoutItem checkoutItem)
        {
            if (checkoutItem == null)
            {
                throw new ArgumentNullException("Checkout.AddItem: checkoutItem");
            }

            Items.Add(checkoutItem);
        }
    }
}
