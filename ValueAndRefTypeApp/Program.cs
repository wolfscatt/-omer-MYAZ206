using ValueAndReferanceType;

var p1 = new ValueAndReferanceType.ValueType
{
    X=10,Y=20
};
var p2 = p1;
p2.X = 30;

Console.WriteLine($"P1: X={p1.X} Y={p1.Y}");
Console.WriteLine($"P2: X={p2.X} Y={p2.Y}");


Console.ReadKey();