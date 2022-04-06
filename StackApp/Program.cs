using DataStructures.Stack;
string msg = "SELAM";

var stack = new DataStructures.Stack.Stack<char>(StackType.Array);

for (int i = 0; i < msg.Length; i++)
{
    stack.Push(msg[i]);
}
var n = stack.Count;

for (int i = 0; i < n; i++)
{
    Console.WriteLine(stack.Pop());
}

Console.ReadKey();