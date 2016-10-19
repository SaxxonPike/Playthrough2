using System;
using System.Threading;
using System.Windows.Forms;

namespace Playthrough2.UI
{
    static class Program
    {
        private static readonly Mutex ApplicationMutex = new Mutex(true, "{15057894-1411-41ae-8323-7224fd4fc9ca}");

        [STAThread]
        static void Main()
        {
            if (ApplicationMutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ConfigurationForm());
                ApplicationMutex.ReleaseMutex();
            }
            else
            {
                Win32.PostMessage(
                    (IntPtr)Win32.HWND_BROADCAST,
                    Win32.WM_SHOWME,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }
        }
    }
}
