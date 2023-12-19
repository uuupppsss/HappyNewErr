using System.Diagnostics;
using System.Drawing;

public class SnowMan : ISmallPaint
{
    static Graphics graphics;
    public void Paint()
    {
        graphics = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);

        graphics.FillEllipse()
    }
}