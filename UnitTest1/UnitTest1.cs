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



            //// Open the app
            //var application = Application.Launch(@"C:\Program Files\IDEA StatiCa\StatiCa 20.0\IDEAStatiCa.exe");

            //// Finds the main window 
            //var window = application.GetWindow("IDEA StatiCa");

            //// Find the button
            //var closeBtn = window.Get<Button>("PART_Close");

            //// Click button
            //closeBtn.Click();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var window = new MainWindow();

            window.ClickOnSteelButton();


            //// Open the app
            //var application = Application.Launch(@"C:\Program Files\IDEA StatiCa\StatiCa 20.0\IDEAStatiCa.exe");

            //// Finds the main window 
            //var window = application.GetWindow("IDEA StatiCa");


            ////// Find the button - takto to nefunguje!!
            ////var steelBtn = window.Get<RadioButton>("STEEL");

            ////// Click button
            ////steelBtn.Click();

            //// Find the button
            //var steelBtn = window.Get<RadioButton>(SearchCriteria.ByText("STEEL"));
            //steelBtn.Click();

            

            




        }

    }
}
