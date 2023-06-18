using Ellipsoid;

//Console.WriteLine("Hello, World!");
EllipsoidClass ellipsoid = new EllipsoidClass
{
    X = 10,
    Y = 5,
    Z = 3
};

EllipsoidClass ellipsoid2 = new EllipsoidClass
{
    X = 5,
    Y = 5,
    Z = 5
};

Area area = new Area
{
    X = 10,
    Y = 10,
    Z = 10,
    Radius = 5
};

bool isInside =  ellipsoid.Volume() <= area.Volume();
//Console.WriteLine (isInside);
ellipsoid.GenerateRandomPoints(1, 2, 3, 10);
Console.WriteLine(EllipsoidClass.isInsideArea(area, ellipsoid));
Console.WriteLine(EllipsoidClass.CheckCollision(ellipsoid, ellipsoid2));
