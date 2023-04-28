using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        while (number != 0) {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
        }
        int max = 0;
        int min = numbers[0];
        int temp = 0;
        int NumList = numbers.Count;
        Console.WriteLine($"The number of items in the list is {NumList}.");
        int SumNum = 0;
        foreach (int num in numbers) {
            SumNum += num;
            if (num > temp) {
                max = num;
                temp = num;
            }
            if (num < min) {
                min = num;
            }
        }
        float average = (float)SumNum / (float)NumList;
        Console.WriteLine("");
        Console.WriteLine($"Maximum number is {max}.");
        Console.WriteLine($"Minimum number is {min}.");
        Console.WriteLine($"The sum of the numbers in the list is {SumNum}.");
        Console.WriteLine($"The average number in the list is {average}.");
        numbers.Sort();
        Console.WriteLine($"The sorted list is: ");
        foreach (int num in numbers) {
            Console.Write("  {0}", num);
        }
    }
}