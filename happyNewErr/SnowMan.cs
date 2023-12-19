using System.Diagnostics;
using System.Drawing;

public class SnowMan : ISmallPaint
{
    public void Paint(Graphics graphics)
    {

        graphics.FillPolygon(Brushes.Black, new Point[] {
            new Point(255, 120),
            new Point(310, 120),
            new Point(310, 70),
            new Point(255, 70)
            });

        Pen arms = new Pen(Color.Black, 4);
        graphics.DrawCurve(arms, new Point[] {
            new Point(265, 160),
            new Point(200, 120),
            });

        graphics.FillEllipse(Brushes.WhiteSmoke, 250, 200, 100, 100);
        graphics.FillEllipse(Brushes.WhiteSmoke, 250, 140, 80, 80);
        graphics.FillEllipse(Brushes.WhiteSmoke, 250, 90, 60, 60);

        graphics.DrawCurve(arms, new Point[] {
            new Point(285, 160),
            new Point(220, 120),
            });

        graphics.FillEllipse(Brushes.Black, 262, 150, 10, 10);
        graphics.FillEllipse(Brushes.Black, 266, 170, 10, 10);
        graphics.FillEllipse(Brushes.Black, 270, 190, 10, 10);
        graphics.FillEllipse(Brushes.Black, 270, 210, 10, 10);

        graphics.FillEllipse(Brushes.Black, 266, 230, 10, 10);
        graphics.FillEllipse(Brushes.Black, 260, 250, 10, 10);
        graphics.FillEllipse(Brushes.Black, 260, 270, 10, 10);



        graphics.FillEllipse(Brushes.Red, 255, 110, 10, 10); 
        graphics.FillEllipse(Brushes.Red, 270, 110, 10, 10);

        graphics.FillPolygon(Brushes.DarkOrange, new Point[] {
            new Point(265, 120),
            new Point(230, 125),
            new Point(260, 130)
            });

        Pen mouth = new Pen(Color.Red, 3);
        graphics.DrawCurve(mouth, new Point[] {
            new Point(255, 133),
            new Point(265, 138),
            new Point(275, 133),
            });
    }
}