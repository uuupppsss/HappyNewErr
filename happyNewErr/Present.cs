using System.Diagnostics;
using System.Drawing;

public class Presents : ISmallPaint
{
    public void Paint(Graphics graphics)
    {
        graphics.FillPolygon(Brushes.CornflowerBlue, new Point[] {
            new Point(120, 220),
            new Point(150, 220),
            new Point(150, 240),
            new Point(120, 240)
            });

        graphics.FillPolygon(Brushes.MediumVioletRed, new Point[] {
            new Point(140, 215),
            new Point(170, 215),
            new Point(170, 240),
            new Point(140, 240)
            });

        graphics.FillPolygon(Brushes.MediumVioletRed, new Point[] {
            new Point(80, 225),
            new Point(120, 225),
            new Point(120, 240),
            new Point(80, 240)
            });

        graphics.FillPolygon(Brushes.RosyBrown, new Point[] {
            new Point(60, 210),
            new Point(30, 210),
            new Point(30, 240),
            new Point(60, 240)
            });
    }
}