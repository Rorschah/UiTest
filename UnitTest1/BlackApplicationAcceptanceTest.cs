using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            BlackApplicationHandler.StopAllInstances();
        }



        [TestMethod]
        public void ShouldOpenMainWindowsOnApplicationStart()
        {
            /// GIVEN

            /// the "black application" is not running
            /// 

            /// WHEN

            /// start the "black application"
            BlackApplicationInstance blackAplicationInstance = BlackApplicationHandler.StartNewInstance();

            /// THEN
            /// 

            /// check the main window has menu for Steel, Concrete and BIM
            blackAplicationInstance.CheckMainWindowsHasTheSteelButton();
            blackAplicationInstance.CheckMainWindowsHasTheConcreteButton();
            blackAplicationInstance.CheckMainWindowsHasTheBimButton();
        }
    }
}
