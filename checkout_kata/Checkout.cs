﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace checkout_kata
{
    /// <summary>
    /// A checkout system.
    /// </summary>
    public class Checkout
    {
        /// <summary>
        /// A list of items.
        /// </summary>
        public List<CheckoutItem> Items { get; private set; }

        /// <summary>
        /// Constructs and initialises a new instance of Checkout.
        /// </summary>
        public Checkout()
        {
            Items = new List<CheckoutItem>();
        }

        /// <summary>
        /// Adds the given <paramref name="checkoutItem"/> to this checkout
        /// </summary>
        /// <param name="checkoutItem">The item to add.</param>
        public void AddItem(CheckoutItem checkoutItem)
        {
            if (checkoutItem == null)
            {
                throw new ArgumentNullException("Checkout.AddItem: checkoutItem");
            }

            Items.Add(checkoutItem);
        }

        /// <summary>
        /// Sum up the values of <see cref="Items"/>
        /// </summary>
        /// <returns></returns>
        public decimal CalculateTotal()
        {
            if (Items == null)
            {
                return 0;
            }

            return Items.Sum(item => item.Price);
        }
    }
}
