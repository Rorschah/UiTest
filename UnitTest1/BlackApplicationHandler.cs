using System.Diagnostics;

namespace AcceptanceTests
{
    class BlackApplicationHandler
    {

        static internal void StopAllInstances()
        {
            foreach (Process p in System.Diagnostics.Process.GetProcessesByName("IDEAStatiCa"))
            {
                
                    p.CloseMainWindow();
                    p.WaitForExit(); // possibly with a timeout
                
                //catch (Win32Exception winException)
                //{
                //    // process was terminating or can't be terminated - deal with it
                //}
                //catch (InvalidOperationException invalidException)
                //{
                //    // process has already exited - might be able to let this one go
                //}
            }
        }

        static internal BlackApplicationInstance StartNewInstance()
        {
            return new BlackApplicationInstance();
        }
    }
}
