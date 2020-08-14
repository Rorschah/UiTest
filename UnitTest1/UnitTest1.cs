using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow window = new MainWindow();

            window.ClickOnCloseButton();
        }

        [TestMethod]
        public void TestMethod2()
        {
            MainWindow window = new MainWindow();

            window.ClickOnSteelButton();
        }

        [TestMethod]
        public void TestMethod3()
        {

            MainWindow window = new MainWindow();

            // Open preferences window
            var preferencesWindow = window.OpenPreferencesWindow();

            // Switch language
            preferencesWindow.SwitchLanguage((Language.Italian).ToString()); // mohu vybrat jazyk dle "Enum"

            // Click on "Cancel"
            preferencesWindow.ClickOnCancelButton();

        }
    }
}
