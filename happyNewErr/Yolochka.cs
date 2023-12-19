using System.Diagnostics;
using System.Drawing;
public class Yolochka: ISmallPaint
{
    public void Paint(Graphics graphics)
    {
        graphics.FillPolygon(Brushes.DarkOliveGreen, new Point[] {
            new Point(100, 70),
            new Point(120, 120),
            new Point(80, 120)
            });

        graphics.FillPolygon(Brushes.DarkOliveGreen, new Point[] {
            new Point(100, 100),
            new Point(150, 150),
            new Point(50, 150)
            });

        graphics.FillPolygon(Brushes.DarkOliveGreen, new Point[] {
            new Point(100, 130),
            new Point(180, 180),
            new Point(20, 180)
            });

        graphics.FillPolygon(Brushes.DarkOliveGreen, new Point[] {
            new Point(100, 160),
            new Point(210, 210),
            new Point(0, 210)
            });

        graphics.FillPolygon(Brushes.SaddleBrown, new Point[] {
            new Point(90, 210),
            new Point(110, 210),
            new Point(110, 240),
            new Point(90, 240)
            });
    }
}