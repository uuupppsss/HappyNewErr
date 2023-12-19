using System.Diagnostics;
using System.Drawing;

public class BackGround : ISmallPaint
{
    Random random = new Random();
    public void Paint(Graphics graphics)
    {
        graphics.FillPolygon(Brushes.DeepSkyBlue, new Point[] {
            new Point(0, 0),
            new Point(0, 350),
            new Point(350, 350),
            new Point(350, 0)
        });

        int num = random.Next(50, 150);
        for (int i = 0; i < num; i++)
        {
            int x = random.Next(0, 340);
            int y = random.Next(0, 340);
            graphics.FillEllipse(Brushes.LightGray, x, y, 5, 5);
        }

        graphics.FillEllipse(Brushes.LightGray, 0, 0, 80, 80);

    }
}