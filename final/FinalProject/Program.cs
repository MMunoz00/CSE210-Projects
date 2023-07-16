using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!\n");
        Console.WriteLine("===================================================================");
        Console.WriteLine("Welcome to the Dungeons & Dragons Generation Program Tool! (D&DGPT)");
        Console.WriteLine("===================================================================\n");
        Console.Write("Press enter to continue...");
        Console.ReadLine();
        Console.WriteLine();
        Character character = new Character();
        character.GetName();
        Console.WriteLine("Would you like to input your own stat scores?");
        Console.WriteLine("Enter Y or N:  ");
        string input = character.CheckYorN();
        if (input == "y") {
            character.GetStats();
        }
        else {
            Console.Write("Generating Stats...   ");
            character.Animate(3);
            character.GenerateStats();
            character.Animate(3);
        }
        character.GetRace();
        character.GetClass();
        character.DisplayCharacter();        
    }
}

class Character {
    protected string name;
    public int constitution {get; set;} = 0;
    public int dexterity {get; set;} = 0;
    public int strength {get; set;} = 0;
    public int wisdom {get; set;} = 0;
    public int intelligence {get; set;} = 0;
    public int charisma {get; set;} = 0;
    public List<int> scores = new List<int>();
    public Random randGen = new Random();
    public int random;
    public int speed;
    public int hitpoints;
    protected Race race = new Race();
    protected Class classType = new Class();

    public Character() {

    }

    public void EndProgram() {
        Console.WriteLine("Goodbye!");
        Thread.Sleep(3000);
        Environment.Exit(0);
    }

    public void GetRace() {
        int choice;
        Console.WriteLine("Select a race for your character\n");
        Console.WriteLine("\t1. Dwarf");
        Console.WriteLine("\t2. Dragonborn");
        Console.WriteLine("\t3. Elf");
        Console.WriteLine("\t4. Gnome");
        Console.WriteLine("\t5. Half-Elf");
        Console.WriteLine("\t6. Halfling");
        Console.WriteLine("\t7. Half-Orc");
        Console.WriteLine("\t8. Human");
        Console.WriteLine("\t9. Tiefling");
        Console.WriteLine("\t0. Cancel Character Creation");
        Console.WriteLine();
        Console.Write("Enter your choice:  ");
        choice = CheckValue(9);
        if (choice == 1) {
            race = GetSubRace(choice);
            race.UpdateStats(this);
        }
        else if (choice == 2) {
            race = new Dragonborn();
            race.UpdateStats(this);
        }
        else if (choice == 3) {
            race = GetSubRace(choice);
            race.UpdateStats(this);
        }
        else if (choice == 4) {
            race = GetSubRace(choice);
            race.UpdateStats(this);
        }
        else if (choice == 5) {
            race = new HalfElf();
            race.UpdateStats(this);
        }
        else if (choice == 6) {
            race = GetSubRace(choice);
            race.UpdateStats(this);
        }
        else if (choice == 7) {
            race = new HalfOrc();
            race.UpdateStats(this);
        }
        else if (choice == 8) {
            race = new Human();
            race.UpdateStats(this);
        }
        else if (choice == 9) {
            race = new Tiefling();
            race.UpdateStats(this);
        }
        else {
            EndProgram();
        }
    }

    public Race GetSubRace(int race) {
        int choice;
        if (race == 1) {
            Console.WriteLine("Select a subrace for your race");
            Console.WriteLine("\t1. Hill Dwarf");
            Console.WriteLine("\t2. Mountain Dwarf");
            Console.WriteLine("\t0. Cancel Character Creation");
            choice = CheckValue(2);
            if (choice == 1) {
                return new HillDwarf();
            }
            else if (choice == 2) {
                return new MountainDwarf();
            }
            else {
                EndProgram();
                return new Race();
            }
        }
        else if (race == 3) {
            Console.WriteLine("Select a subrace for your race");
            Console.WriteLine("\t1. Dark Elf");
            Console.WriteLine("\t2. High Elf");
            Console.WriteLine("\t3. Wood Elf");
            Console.WriteLine("\t0. Cancel Character Creation");
            choice = CheckValue(3);
            if (choice == 1) {
                return new DarkElf();
            }
            else if (choice == 2) {
                return new HighElf();
            }
            else if (choice == 3) {
                return new WoodElf();
            }
            else {
                EndProgram();
                return new Race();
            }
        }
        else if (race == 4) {
            Console.WriteLine("Select a subrace for your race");
            Console.WriteLine("\t1. Forest Gnome");
            Console.WriteLine("\t2. Rock Gnome");
            Console.WriteLine("\t0. Cancel Character Creation");
            choice = CheckValue(2);
            if (choice == 1) {
                return new ForestGnome();
            }
            else if (choice == 2) {
                return new RockGnome();
            }
            else {
                EndProgram();
                return new Race();
            }
        }
        else if (race == 6) {
            Console.WriteLine("Select a subrace for your race");
            Console.WriteLine("\t1. Lightfoot Halfling");
            Console.WriteLine("\t2. Stout Halfling");
            Console.WriteLine("\t0. Cancel Character Creation");
            choice = CheckValue(2);
            if (choice == 1) {
                return new LightfootHalfling();
            }
            else if (choice == 2) {
                return new StoutHalfling();
            }
            else {
                EndProgram();
                return new Race();
            }
        }
        else {
            EndProgram();
            return new Race();
        }
    }

    public Class GetClass() {
        int choice;
        Console.WriteLine("Select a class for your character\n");
        Console.WriteLine("\t1. Barbarian");
        Console.WriteLine("\t2. Bard");
        Console.WriteLine("\t3. Cleric");
        Console.WriteLine("\t4. Druid");
        Console.WriteLine("\t5. Fighter");
        Console.WriteLine("\t6. Monk");
        Console.WriteLine("\t7. Paladin");
        Console.WriteLine("\t8. Ranger");
        Console.WriteLine("\t9. Rogue");
        Console.WriteLine("\t10. Sorcerer");
        Console.WriteLine("\t11. Warlock");
        Console.WriteLine("\t12. Wizard");
        Console.WriteLine("\t0. Cancel Character Creation");
        Console.WriteLine();
        Console.Write("Enter your choice:  ");
        choice = CheckValue(12);
        if (choice == 1) {
            classType = new Barbarian();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 2) {
            classType = new Bard();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 3) {
            classType = new Cleric();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 4) {
            classType = new Druid();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 5) {
            classType = new Fighter();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 6) {
            classType = new Monk();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 7) {
            classType = new Paladin();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 8) {
            classType = new Ranger();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 9) {
            classType = new Rogue();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 10) {
            classType = new Sorcerer();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 11) {
            classType = new Warlock();
            classType.SetStats(this);
            return classType;
        }
        else if (choice == 12) {
            classType = new Wizard();
            classType.SetStats(this);
            return classType;
        }
        else {
            EndProgram();
            return new Class();
        }
    }

    public void GetName() {
        Console.WriteLine("Please enter your character's name.");
        Console.Write("Name: ");
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
            random = randGen.Next(3, 19);
            Console.Write($"{random} ");
            scores.Add(random);
        }
        Console.WriteLine();
    }

    public int SetStatMod(int stat) {
        int mod = 0;
        if (stat == 2 | stat == 3) {
            mod = -4;
        }
        else if (stat == 4 | stat == 5) {
            mod = -3;
        }
        else if (stat == 6 | stat == 7) {
            mod = -2;
        }
        else if (stat == 8 | stat == 9) {
            mod = -1;
        }
        else if (stat == 10 | stat == 11) {
            mod = 0;
        }
        else if (stat == 12 | stat == 13) {
            mod = 1;
        }
        else if (stat == 14 | stat == 15) {
            mod = 2;
        }
        else if (stat == 16 | stat == 17) {
            mod = 3;
        }
        else if (stat == 18 | stat == 19) {
            mod = 4;
        }
        else if (stat == 20) {
            mod = 5;
        }
        return mod;
    }

    public void DisplayStats() {
        Console.WriteLine($"CON: {constitution}\t| {SetStatMod(constitution)}");
        Console.WriteLine($"STR: {strength}\t| {SetStatMod(strength)}");
        Console.WriteLine($"DEX: {dexterity}\t| {SetStatMod(dexterity)}");
        Console.WriteLine($"INT: {intelligence}\t| {SetStatMod(intelligence)}");
        Console.WriteLine($"WIS: {wisdom}\t| {SetStatMod(wisdom)}");
        Console.WriteLine($"CHA: {charisma}\t| {SetStatMod(charisma)}");
    }

    public void DisplayCharacter() {
        Console.Clear();
        Console.WriteLine($"Name: {name}");
        race.DisplayRace();
        Console.WriteLine();
        Console.WriteLine($"Class: {classType.className}");
        Console.WriteLine("Level: 1\n");
        Console.WriteLine($"Hit Points:  {hitpoints}");
        Console.WriteLine($"Speed: {speed}");
        Console.WriteLine($"Inititative: {SetStatMod(dexterity)}");
        Console.WriteLine();
        Console.WriteLine($"Passive Perception (WISDOM): {SetStatMod(wisdom)}");
        Console.WriteLine();
        DisplayStats();
        Console.WriteLine();
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

    public int CheckValue(int max) {
        string input;
        int value;
        while(true) {
            input = Console.ReadLine();
            try {
                value = int.Parse(input);
                if ((value <= max) & (value >= 0)) {
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

    public void Animate(int seconds) {
        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(seconds);
        List<string> frames = new List<string> {"/", "-", "\\", "|"};
        while (DateTime.Now < endTime) {
            foreach (string frame in frames) {
                Console.Write(frame);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }
}