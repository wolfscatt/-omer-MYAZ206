
var arr= Array.CreateInstance(typeof(int), 4);

arr.SetValue(13, 0);
arr.SetValue(11, 1);
arr.SetValue(53, 2);
arr.SetValue(9, 3);

// 0:13 , 1:11 , 2:53 , 3:9 

Console.WriteLine(arr.GetValue(0));

try
{
    Console.WriteLine(arr.GetValue(5));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

foreach (var item in arr)
{
    Console.WriteLine(item);
}

var _arr = new DataStructures.Array.Array(1,2,3);
foreach (var item in _arr)
{
    Console.WriteLine(item);
}

Console.ReadKey();