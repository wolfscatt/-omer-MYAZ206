using DataStructures.Queue;

var queue = new DataStructures.Queue.Queue<ToDo>();
queue.EnQueue(new ToDo()
{
    Time = 3,
    Describe = "Okula Gidilecek"
});

queue.EnQueue(new ToDo()
{
    Time = 1,
    Describe = "İftar Yapılacak"
});
var result = queue.DeQueue();

Console.WriteLine(result+"Yapıldı");

Console.WriteLine(queue.Count);

foreach (var item in queue)
{
    Console.WriteLine(item);
}
Console.ReadKey();
