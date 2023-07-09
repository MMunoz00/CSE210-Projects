using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        Character character = new Character();
        character.GetName();
        Console.WriteLine("Would you like to input your own stat scores?");
        Console.WriteLine("Enter Y or N:  ");
        string input = character.CheckYorN();
        if (input == "y") {
            character.GetStats();
        }
        else {
            Console.WriteLine("Generating Stats...");
            Thread.Sleep(300);
            character.GenerateStats();
        }

    }
}

class Character {
    protected string name;
    protected int constitution = 0;
    protected int dexterity = 0;
    protected int strength = 0;
    protected int wisdom = 0;
    protected int intelligence = 0;
    protected int charisma = 0;
    protected List<int> scores = new List<int>();
    protected Random randGen = new Random();
    protected int random;

    public Character() {

    }

    public void GetName() {
        Console.WriteLine("Please enter your character's name.");
        Console.Write("Name:  ");
        name = Console.ReadLine();
    }

    public void GetStats() {
        scores.Clear();
        int score;
        for (int i = 0; i < 6; i++) {
            Console.Write("Enter a stat score: ");
            score = CheckScore();
            scores.Add(score);
        }
    }

    public void GenerateStats() {
        scores.Clear();
        for (int i = 0; i < 6; i++) {
            random = randGen.Next(3, 18);
            Console.WriteLine(random);
        }
    }

    public void DisplayStats() {
        Console.WriteLine("Your stats m'Lord:\n");
        Console.WriteLine($"CON: {constitution}");
        Console.WriteLine($"STR: {strength}");
        Console.WriteLine($"DEX: {dexterity}");
        Console.WriteLine($"INT: {intelligence}");
        Console.WriteLine($"WIS: {wisdom}");
        Console.WriteLine($"CHA: {charisma}");
    }

    public int CheckScore() {
        string input;
        int value;
        while(true) {
            input = Console.ReadLine();
            try {
                value = int.Parse(input);
                if (value >= 3 & value <= 18) {
                    return value;
                }
                else {
                    Console.WriteLine("Invalid input");
                }
            }
            catch(Exception) {
                Console.WriteLine("Invalid input");
            }
        }
    }

    public string CheckYorN() {
        string input;
        while(true) {
            input = Console.ReadLine();
            if (input == "Y" | input == "y") {
                input = "y";
                return input;
            }
            else if (input == "N" | input == "n") {
                input = "n";
                return input;
            }
            else {
                Console.WriteLine("Invalid input");
            }
        }
    }
}