using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenLaunchingAppThenAppWindowOpens()
        {
            MainWindow window = new MainWindow();

            window.ClickOnCloseButton();
        }

        [TestMethod]
        public void WhenAppWindowIsOpenedThenSteelButtonExists()
        {
            MainWindow window = new MainWindow();

            window.ClickOnSteelButton();
        }

        [TestMethod]
        public void WhenChangingLanguageThenLanguageIsChanged()
        {

            MainWindow window = new MainWindow();

            // Open preferences window
            var preferencesWindow = window.OpenPreferencesWindow();

            // Switch language
            preferencesWindow.SwitchLanguage(Language.French); // mohu vybrat jazyk dle "Enum"

            // Click on "Cancel"
            preferencesWindow.ClickOnCancelButton();

            
        }
    }
}
