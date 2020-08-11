using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Open the app
            var application = Application.Launch(@"C:\Program Files\IDEA StatiCa\StatiCa 20.0\IDEAStatiCa.exe");

            // Finds the main window 
            var window = application.GetWindow("IDEA StatiCa");

            // Find the button
            var closeButton = window.Get<Button>("PART_Close");

            // Click button
            closeButton.Click();
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Open the app
            var application = Application.Launch(@"C:\Program Files\IDEA StatiCa\StatiCa 20.0\IDEAStatiCa.exe");

            // Finds the main window 
            var window = application.GetWindow("IDEA StatiCa");


            //// Find the button - takto to nefunguje!!
            //var steelBtn = window.Get<RadioButton>("STEEL");

            //// Click button
            //steelBtn.Click();

            // Find the button
            var steelButton = window.Get<RadioButton>(SearchCriteria.ByText("STEEL"));
            steelButton.Click();

            

            




        }

    }
}
