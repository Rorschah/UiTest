using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace UnitTest1
{
    internal class BlackApplicationInstance
    {
        private readonly Window window;
        private readonly Application application;

        public BlackApplicationInstance()
        {
            application = Application.Launch(@"C:\Program Files\IDEA StatiCa\StatiCa 20.0\IDEAStatiCa.exe");

            window = application.GetWindow("IDEA StatiCa");
        }

        internal void ClickOnCloseButton()
        {
            var closeButton = window.Get<Button>("PART_Close");

            closeButton.Click();
        }

        internal void ClickOnSteelButton()
        {
            var steelButton = window.Get<RadioButton>(SearchCriteria.ByText("STEEL"));
            steelButton.Click();
        }

        internal PreferencesWindow OpenPreferencesWindow()
        {
            // Open prefences window
            var preferencesButton = window.Get<Button>("PART_Options");
            preferencesButton.Click();
            var preferencesWindow = Retry.For(
                () => application.GetWindows().First(x => x.Id == "thisWindow"), TimeSpan.FromSeconds(5));


            return new PreferencesWindow(preferencesWindow); // vraceni noveho objektu, aniz bych ho musel priradit do nove promenne
        }
    }
}