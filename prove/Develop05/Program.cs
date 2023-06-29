using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!\n");
        bool cont = true;
        string input;
        int choice;
        int num;
        FileManager file = new FileManager();
        double points = 0;

        var goals = new List<Goal>();
        Console.Clear();

        while (cont == true) {
            Console.WriteLine("Choose a menu option\n");
            Console.WriteLine("1. Create a Simple Goal");
            Console.WriteLine("2. Create an Eternal Goal");
            Console.WriteLine("3. Create a Checklist Goal");
            Console.WriteLine("4. Display Goals");
            Console.WriteLine("5. Record Goal Completion");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Start New Goals");
            Console.WriteLine("0. Exit Program");
            Console.WriteLine();
            Console.WriteLine($"Total points = {points}");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            while (true) {
                input = Console.ReadLine();
                try {
                    choice = int.Parse(input);
                    if ((choice >= 0) & (choice <= 8)){
                        break;
                    }
                    else{
                        Console.Write("Invalid input, please try again: ");
                    }
                }
                catch(Exception) {
                    Console.Write("Invalid input, please try again: ");
                }
            }
            Console.WriteLine();

            if (choice == 1) {
                SimpleGoal simple = new SimpleGoal();
                goals.Add(simple);
                Console.Clear();
            }
            else if (choice == 2) {
                EternalGoal eternal = new EternalGoal();
                goals.Add(eternal);
                Console.Clear();
            }
            else if (choice == 3) {
                ChecklistGoal checklist = new ChecklistGoal();
                goals.Add(checklist);
                Console.Clear();
            }
            else if (choice == 4) {
                foreach (Goal goal in goals) {
                    goal.DisplayGoal();
                }
                Console.Write("\nPress enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
            else if (choice == 5) {
                num = 1;
                foreach (Goal goal in goals) {
                    Console.Write($"{num}. ");
                    goal.DisplayGoal();
                    num++;
                }
                Console.Write("\nSelect a goal to complete: ");
                num = Convert.ToInt32(GetDouble()) - 1;
                goals[num].RecordEvent();
                points += goals[num].GetPoints();
                Console.Clear();
            }
            else if (choice == 6) {
                Console.Write("Please give the file you are saving a name: ");
                string filename = Console.ReadLine();
                file.SaveGoals(goals, filename, points);
                Console.Clear();
            }
            else if (choice == 7) {
                Console.Write("Enter the name of the file you wish to open: ");
                string filename = Console.ReadLine();
                goals = file.LoadGoals(filename);
                points = file.LoadPoints(filename);
                Console.Clear();
            }
            else if (choice == 8) {
                goals = new List<Goal>();
                points = 0;
                Console.Clear();
            }
            else if (choice == 0) {
                Console.WriteLine("\nThanks for using my program!");
                Console.WriteLine("Goodbye!\n");
                cont = false;
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }

    static double GetDouble() {
        string input;
        double value;
        while(true) {
            input = Console.ReadLine();
            try {
                value = double.Parse(input);
                return value;
            }
            catch(Exception) {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }
}

public class Goal {
    protected string goalName = "";
    protected string goalDescription = "";
    protected bool goalCompleted = false;
    protected double points = 0;

    public Goal() {
    }


    public double GetDouble() {
        string input;
        double value;
        while(true) {
            input = Console.ReadLine();
            try {
                value = double.Parse(input);
                return value;
            }
            catch(Exception) {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }

    public virtual void CreateGoal() {
        Console.Write("Enter a goal for you to complete: ");
        goalName = Console.ReadLine();
        Console.Write("Enter a description of your goal: ");
        goalDescription = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        points = GetDouble();
    }

    public virtual void DisplayGoal() {
        if (goalCompleted == false) {
            Console.WriteLine($"[ ] {goalName}: {goalDescription}");
        }
        else {
            Console.WriteLine($"[X] {goalName}: {goalDescription}");
        }
    }   

    public virtual void RecordEvent() {
        if (goalCompleted == false) {
            goalCompleted = true;
        }
        else {
            points = 0;
        }
    }

    public virtual string GetDataForm() {
        var data = $"Simple;{goalName};{goalDescription};{points};{goalCompleted}";
        return data;
    }

    public virtual double GetPoints() {
        return points;
    }
}

public class SimpleGoal: Goal {
    public SimpleGoal() {
        CreateGoal();
    }

    public SimpleGoal(string Name, string Description, double Points, bool Completed) {
        goalName = Name;
        goalDescription = Description;
        points = Points;
        goalCompleted = Completed;
    }
}

public class EternalGoal: Goal {
    private double _currentCount = 0;

    public EternalGoal() {
        CreateGoal();
    }

    public EternalGoal(string Name, string Description, double Points, double currentCount) {
        goalName = Name;
        goalDescription = Description;
        points = Points;
        _currentCount = currentCount;
    }

    public override void DisplayGoal() {
        Console.WriteLine($"[ ] {goalName}: {goalDescription}\nTimes completed: {_currentCount}");
    }

    public override void RecordEvent() {
        base.RecordEvent();
        goalCompleted = false;
        _currentCount++;
    }

    public override string GetDataForm() {
        var data = $"Eternal;{goalName};{goalDescription};{points};{_currentCount}";
        return data;
    }
}

public class ChecklistGoal: Goal {
    private double _completeCount;
    private double _currentComplete = 0;
    private double _bonusPoints;

    public ChecklistGoal() {
        CreateGoal();
    }

    public ChecklistGoal(string Name, string Description, double Points, bool Completed, double currentCount, double completeCount, double bonusPoints) {
        goalName = Name;
        goalDescription = Description;
        points = Points;
        _currentComplete = currentCount;
        _completeCount = completeCount;
        _bonusPoints = bonusPoints;
        goalCompleted = Completed;
    }

    public override void CreateGoal() {
        base.CreateGoal();
        Console.Write("How many times will you need to complete this goal?: ");
        _completeCount = GetDouble();
        Console.Write("How many bonus points for total completion?: ");
        _bonusPoints = GetDouble();

    }

    public override void DisplayGoal() {
        if (goalCompleted == false) {
            Console.WriteLine($"[ ] {goalName}: {goalDescription}\n{_currentComplete}/{_completeCount} completed");
        }
        else {
            Console.WriteLine($"[X] {goalName}: {goalDescription}\n{_currentComplete}/{_completeCount} completed");
        }
    }

    public override void RecordEvent() {
        _currentComplete++;
        if (goalCompleted == false) {
            if (_currentComplete == _completeCount) {
                goalCompleted = true;
            }
        }
    }

    public override double GetPoints() {
        if (_currentComplete == _completeCount) {
            return points + _bonusPoints;
        }
        else {
            return points;
        }
    }

    public override string GetDataForm() {
        var data = $"Checklist;{goalName};{goalDescription};{points};{goalCompleted};{_currentComplete};{_completeCount};{_bonusPoints}";
        return data;
    }
}

public class FileManager {
    public void SaveGoals(List<Goal> goals, string filename, double totalPoints) {
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            outputFile.WriteLine(totalPoints);
            foreach (var goal in goals) {
                string data = goal.GetDataForm();
                outputFile.WriteLine(data);
            }
        }
    }
    public List<Goal> LoadGoals(string filename) {
        List<Goal> goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        for (int i = 1; i < (lines.Count()); i++) {
            string[] parts = lines[i].Split(";");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            double points = double.Parse(parts[3]);
            if (goalType == "Simple") {
                bool goalCompleted = bool.Parse(parts[4]);
                SimpleGoal simple = new SimpleGoal(goalName, goalDescription, points, goalCompleted);
                goals.Add(simple);
            }
            else if (goalType == "Eternal") {
                double currentCount = double.Parse(parts[4]);
                EternalGoal eternal = new EternalGoal(goalName, goalDescription, points, currentCount);
                goals.Add(eternal);
            }
            else if (goalType == "Checklist") {
                bool goalCompleted = bool.Parse(parts[4]);
                double currentCount = double.Parse(parts[5]);
                double completeCount = double.Parse(parts[6]);
                double bonusPoints = double.Parse(parts[7]);
                ChecklistGoal checklist = new ChecklistGoal(goalName, goalDescription, points, goalCompleted, currentCount, completeCount, bonusPoints);
                goals.Add(checklist);
            }
        }
        return goals;
    }
    public double LoadPoints(string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);
        double totalPoints = double.Parse(lines[0]);

        return totalPoints;
    }
}