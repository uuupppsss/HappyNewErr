NewYearPaint paint = new NewYearPaint();

Yolochka yolochka = new Yolochka();
YolochkasToys yolochkasToys = new YolochkasToys();
Presents presents = new Presents();


paint.AddPaintObject(yolochka);
paint.AddPaintObject(yolochkasToys);
paint.AddPaintObject(presents);

paint.Create();
Console.ReadLine();

