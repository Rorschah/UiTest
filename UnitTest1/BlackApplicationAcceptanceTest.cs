using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;

namespace AcceptanceTests
{
    [TestClass]
    public class BlackApplicationAcceptanceTest
    {

        [TestInitialize]
        public void Setup()
        {
            // Runs before each test. (Optional)
            BlackApplicationHandler.StopAllInstances();
        }

        [TestCleanup]
        public void TearDown()
        {
            // Runs after each test. (Optional)
        }



        [TestMethod]
        public void WhenLaunchingAppThenAppWindowOpens()
        {
            BlackApplicationInstance blackAplicationInstance = BlackApplicationHandler.StartNewInstance();
            blackAplicationInstance.ClickOnCloseButton();
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
