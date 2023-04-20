using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "O";
        int check = grade % 10;
        string sign = "";

        if (grade >= 97 || grade < 60)
        {
            sign = "";
        }
        else if (check >= 7)
        {
            sign = "+";
        }
        else if (check <= 3)
        {
            sign = "-";
        }
        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats, you've passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass the class.");
        }
    }
}