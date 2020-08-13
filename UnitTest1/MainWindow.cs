using System;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace UnitTest1
{
    internal class MainWindow
    {
        private readonly Window window;

        public MainWindow()
        {
            var application = Application.Launch(@"C:\Program Files\IDEA StatiCa\StatiCa 20.0\IDEAStatiCa.exe");

            window = application.GetWindow("IDEA StatiCa");
        }

        internal void ClickOnCloseButton()
        {
            var closeButton = window.Get<Button>("PART_Close");

            closeButton.Click();
        }

        internal void ClickOnSteelButton()
        {
            throw new NotImplementedException();
        }

        internal void OpenPreferencesWindow()
        {
            var preferencesButton = window.Get<Button>("PART_Options");
            preferencesButton.Click();
        }
    }
}