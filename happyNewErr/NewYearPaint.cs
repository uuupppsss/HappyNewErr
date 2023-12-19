using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NewYearPaint
{
    public List<ISmallPaint> paint_objects = new List<ISmallPaint>();

    public void Create()
    {
        foreach (var obj in paint_objects)
        {
            obj.Paint();
        }
    }

    public void AddPaintObject(ISmallPaint obj)
    {
        paint_objects.Add(obj);
    }
}
