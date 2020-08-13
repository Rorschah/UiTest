using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var window = new MainWindow();

            window.ClickOnCloseButton();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var window = new MainWindow();

            window.ClickOnSteelButton();
        }
    }
}
