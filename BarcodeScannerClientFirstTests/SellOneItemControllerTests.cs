using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarcodeScannerClientFirstTests
{
    [TestClass]
    public class SellOneItemControllerTests
    {
        [TestMethod]
        public void ProductFound()
        {
            SaleController.OnBarcode("12345");

            Assert.AreEqual(Display.DisplayPrice(Price.Cents(795)));
        }
    }
}
