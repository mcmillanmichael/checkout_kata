﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata.test
{
    /// <summary>
    /// A set of tests for the MultiBuySpecialOffer class.
    /// </summary>
    [TestClass]
    public class TestMultiBuySpecialOffer
    {
        #region TestSpecialOffers

        /// <summary>
        /// Test that the multibuy special offer can be instantiated
        /// </summary>
        [TestMethod]
        public void TestSpecialOffersCanBeConstructed()
        {
            // Arrange
            ISpecialOffer specialOffer;

            // Act
            specialOffer = new MultiBuySpecialOffer(3, 130);

            // Assert
            // ..
        }

        #endregion
    }
}
