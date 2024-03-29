using LiskovSubstitution.Object;

Console.WriteLine("==============================");
Console.WriteLine("");

Rectangle rc = new Rectangle(2, 3);
getAreaTest(rc);

Rectangle sq = new Square();
sq.SetWidth(5);
getAreaTest(sq);

Console.WriteLine("");
Console.WriteLine("==============================");


static void getAreaTest(Rectangle r)
{
    int width = r.GetWidth();
    r.SetHeight(10);
    Console.WriteLine("Expected area of " + (width * 10) + ", got " + r.GetArea());
}