using System;
using System.Runtime.InteropServices;

class Program
{
    // Import the Win32 function to open or close the CD tray
    [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

    static void Main()
    {
        // Open the CD tray
        mciSendString("set CDAudio door open", "", 0, 0);
    }
}