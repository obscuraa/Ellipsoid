using Ellipsoid;

//Console.WriteLine("Hello, World!");
EllipsoidClass ellipsoid = new EllipsoidClass
{
    X = 10,
    Y = 5,
    Z = 3
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
var p = ellipsoid.GenerateRandomPoints(1, 2, 3, 10);
