﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace checkout_kata
{
    /// <summary>
    /// A checkout system.
    /// </summary>
    public class Checkout : ICheckout
    {
        /// <summary>
        /// A list of items.
        /// </summary>
        public List<ICheckoutItem> Items { get; private set; }

        /// <summary>
        /// A list of special offers.
        /// </summary>
        public List<ISpecialOffer> SpecialOffers { get; private set; }

        /// <summary>
        /// Constructs and initialises a new instance of Checkout.
        /// </summary>
        public Checkout()
        {
            Items = new List<ICheckoutItem>();
            SpecialOffers = new List<ISpecialOffer>();
        }

        /// <summary>
        /// Adds the given <paramref name="checkoutItem"/> to this checkout
        /// </summary>
        /// <param name="checkoutItem">The item to add.</param>
        public void AddItem(ICheckoutItem checkoutItem)
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

        /// <summary>
        /// Add a special offer to the checkout
        /// </summary>
        /// <param name="specialOffer">The special offer to add</param>
        public void AddSpecialOffer(ISpecialOffer specialOffer)
        {
            if (specialOffer == null)
            {
                throw new ArgumentNullException("Checkout.AddItem: specialOffer");
            }

            SpecialOffers.Add(specialOffer);
        }
    }
}
