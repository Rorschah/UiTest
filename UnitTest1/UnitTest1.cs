using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

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

            window.OpenPreferencesWindow();




            // preferencesWindow.SwitchLanguage("Italian");

            //preferencesWindow.ClickOnCancelButton();


            /////////////////////////////
            // Od Kuby

            //PreferencesWindow preferencesWindow = window.OpenPreferencesWindow();

            //preferencesWindow.SwitchLanguage("Italian");

            //preferencesWindow.ClickOnCancelButton();
            /////////////////////////////


            //// Find the button
            //var preferencesButton = window.Get<Button>("PART_Options");

            ////Click button
            //preferencesButton.Click();

            //// Find preferences window
            //var preferencesWindow = Retry.For(
            //    () => application.GetWindows().First(x => x.Id == "thisWindow"), TimeSpan.FromSeconds(5));

            //// Find language --> select "Czech"
            //preferencesWindow.Get<ComboBox>("langSelCombo").Select("Italian");

            //// Preference window --> click button Cancel
            //preferencesWindow.Get<Button>(SearchCriteria.ByText("Cancel")).Click();





        }
    }
}
