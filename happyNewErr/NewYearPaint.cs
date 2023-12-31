﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NewYearPaint
{
    public List<ISmallPaint> paint_objects = new List<ISmallPaint>();
    static Graphics graphics;
    public void Create()
    {
        foreach (var obj in paint_objects)
        {
            graphics = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);
            obj.Paint(graphics);
        }
    }

    public void AddPaintObject(ISmallPaint obj)
    {
        paint_objects.Add(obj);
    }
}
