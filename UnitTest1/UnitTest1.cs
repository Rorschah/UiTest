using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenLaunchingAppThenAppWindowOpens()
        {
            BlackApplicationInstance window = new BlackApplicationInstance();

            window.ClickOnCloseButton();
        }

        [TestMethod]
        public void WhenAppWindowIsOpenedThenSteelButtonExists()
        {
            BlackApplicationInstance window = new BlackApplicationInstance();

            window.ClickOnSteelButton();
        }

        [TestMethod]
        public void WhenChangingLanguageThenLanguageIsChanged()
        {

            BlackApplicationInstance window = new BlackApplicationInstance();

            // Open preferences window
            var preferencesWindow = window.OpenPreferencesWindow();

            // Switch language
            preferencesWindow.SwitchLanguage(Language.French); // mohu vybrat jazyk dle "Enum"

            // Click on "Cancel"
            preferencesWindow.ClickOnCancelButton();

            
        }
    }
}
