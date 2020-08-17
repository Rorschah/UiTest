using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace AcceptanceTests
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

        internal void CheckMainWindowHasTheSteelButton()
        {
            var steelButton = window.Get<RadioButton>(SearchCriteria.ByText("STEEL"));
            Assert.IsNotNull(steelButton);
        }

        internal void CheckMainWindowHasTheConcreteButton()
        {
            var concreteButton = window.Get<RadioButton>(SearchCriteria.ByText("CONCRETE"));
            Assert.IsNotNull(concreteButton);
        }

        internal void CheckMainWindowHasTheBimButton()
        {
            var bimButton = window.Get<RadioButton>(SearchCriteria.ByText("BIM"));
            Assert.IsNotNull(bimButton);
        }
    }
}