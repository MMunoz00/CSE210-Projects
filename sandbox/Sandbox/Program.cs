using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        List<int> list = new List<int>{0,5,4,6,2};
        foreach (int item in list) {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        list.Sort();
        foreach (int item in list) {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        list.RemoveAt(3);
        foreach (int item in list) {
            Console.Write($"{item} ");
        }
    }
}