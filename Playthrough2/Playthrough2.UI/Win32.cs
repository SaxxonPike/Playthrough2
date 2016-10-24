using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace Playthrough2.UI
{
    internal static class Win32
    {
        public const int HWND_BROADCAST = 0xFFFF;
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}
