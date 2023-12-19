NewYearPaint paint = new NewYearPaint();

Yolochka yolochka = new Yolochka();
YolochkasToys yolochkasToys = new YolochkasToys();
Presents presents = new Presents();
SnowMan snowMan = new SnowMan();
BackGround backGround = new BackGround();

paint.AddPaintObject(backGround);
paint.AddPaintObject(yolochka);
paint.AddPaintObject(yolochkasToys);
paint.AddPaintObject(presents);
paint.AddPaintObject(snowMan);

paint.Create();
Console.ReadLine();

