using checkout_kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace checkout_kata.test
{
    /// <summary>
    /// A set of tests for the Checkout class.
    /// </summary>
    [TestClass]
    public class TestCheckout
    {
        #region Test_AddItemToCheckout

        /// <summary>
        /// Test that items can be added to a checkout.
        /// </summary>
        /// <remarks>GREEN</remarks>
        [TestMethod]
        public void TestAddItemToCheckout()
        {
            // Arrange
            ICheckout checkout = new Checkout();

            // Act
            checkout.AddItem(new CheckoutItem("A", 50));
            checkout.AddItem(new CheckoutItem("B", 30));

            //Assert
            Assert.AreEqual(2, checkout.Items.Count, "Number of items does not equal 2");
        }
        /// <summary>
        /// Test that null cannot be added to the checkout.
        /// </summary>
        /// <remarks>RED</remarks>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddItemToCheckout_Null()
        {
            // Arrange
            ICheckout checkout = new Checkout();

            // Act
            checkout.AddItem(null);

            //Assert
            Assert.Fail("ArgumentNullException should have been thrown");
        }

        #endregion

        #region TestCalculateTotalPrice

        /// <summary>
        /// Test that the checkout can sum the prices of the items
        /// </summary>
        /// <remarks>GREEN</remarks>
        [TestMethod]
        public void TestCalculateTotalPrice()
        {
            // Arrange
            ICheckout checkout = new Checkout();
            checkout.AddItem(new CheckoutItem("A", 50));
            checkout.AddItem(new CheckoutItem("B", 30));

            // Act
            var total = checkout.CalculateTotal();

            // Assert
            Assert.AreEqual(80, total);
        }

        /// <summary>
        /// Test that the checkout can sum the prices of the items, even if the checkout is empty
        /// </summary>
        /// <remarks>RED</remarks>
        [TestMethod]
        public void TestCalculateTotalPrice_Empty()
        {
            // Arrange
            ICheckout checkout = new Checkout();

            // Act
            var total = checkout.CalculateTotal();

            // Assert
            Assert.AreEqual(0, total);
        }

        #endregion

        #region TestItemCanBeIdentifiedBySKU

        /// <summary>
        /// Test that an item can be identified by it's SKU letter
        /// </summary>
        /// <remarks>In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. 
        /// In our store, we’ll use individual letters of the alphabet(A, B, C, and so on).</remarks>
        [TestMethod]
        public void TestItemCanBeIdentifiedBySKU()
        {
            // Arrange
            ICheckout checkout = new Checkout();

            // Act
            checkout.AddItem(new CheckoutItem("A", 50));
            checkout.AddItem(new CheckoutItem("B", 30));
            checkout.AddItem(new CheckoutItem("C", 20));
            checkout.AddItem(new CheckoutItem("D", 15));

            // Assert
            Assert.AreEqual("A", checkout.Items[0].SKU);
            Assert.AreEqual("B", checkout.Items[1].SKU);
            Assert.AreEqual("C", checkout.Items[2].SKU);
            Assert.AreEqual("D", checkout.Items[3].SKU);
        }

        #endregion
    }
}
