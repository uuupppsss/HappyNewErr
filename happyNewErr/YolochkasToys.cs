using System.Diagnostics;
using System.Drawing;

public class YolochkasToys : ISmallPaint
{
    static Graphics graphics;
    public void Paint()
    {
        graphics = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);

        graphics.FillEllipse(Brushes.DarkRed, 100, 100, 20, 20);
        graphics.FillEllipse(Brushes.DarkRed, 150, 185, 20, 20);
        graphics.FillEllipse(Brushes.DarkRed, 100, 150, 20, 20);
        graphics.FillEllipse(Brushes.DarkRed, 50, 190, 20, 20);

        graphics.FillEllipse(Brushes.AliceBlue, 80, 170, 15, 15);
        graphics.FillEllipse(Brushes.AliceBlue, 110, 190, 15, 15);
        graphics.FillEllipse(Brushes.AliceBlue, 80, 120, 15, 15);
        graphics.FillEllipse(Brushes.AliceBlue, 145, 170, 15, 15);
    }
}