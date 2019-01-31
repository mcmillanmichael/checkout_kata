using checkout_kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace checkout_kata.test
{
    [TestClass]
    public class TestCheckout
    {
        /// <summary>
        /// Test that items can be added to a checkout.
        /// </summary>
        [TestMethod]
        public void TestAddItemToCheckout()
        {
            // Arrange
            var checkout = new Checkout();

            // Act
            checkout.AddItem(new CheckoutItem(50));
            checkout.AddItem(new CheckoutItem(10));

            //Assert
            Assert.AreEqual(2, checkout.Items.Count, "Number of items does not equal 2");
        }
    }
}
