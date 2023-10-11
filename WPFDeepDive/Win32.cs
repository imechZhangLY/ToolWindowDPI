using System;
using System.Runtime.InteropServices;

namespace WPFDeepDive
{
    public static class Win32Library
    {

        // set window as tool window
        public static int SetToolWindow(IntPtr hwnd)
        {
            var extendedStyle = GetWindowLong(hwnd, GWL_EX_STYLE);
            return SetWindowLong(hwnd, GWL_EX_STYLE, (extendedStyle | WS_EX_TOOLWINDOW) & ~WS_EX_APPWINDOW);
        }


        const int GWL_EX_STYLE = -20;
        const int WS_EX_APPWINDOW = 0x00040000;
        const int WS_EX_TOOLWINDOW = 0x00000080;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
    }
}
