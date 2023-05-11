using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        FileManager files = new FileManager();
        string filename;
        int cont = 0;
        Console.WriteLine("Welcome to the Journal program!\n");
        while (cont != 6) {
            Console.WriteLine("========== Main Menu ==========");
            Console.WriteLine("1. Create a new Journal entry.");
            Console.WriteLine("2. Display the currently loaded Journal.");
            Console.WriteLine("3. Save currently loaded Journal to file.");
            Console.WriteLine("4. Load a previously saved Journal.");
            Console.WriteLine("5. Create a new Journal.");
            Console.WriteLine("6. Exit the Program\n");
            Console.Write("Enter a number: ");
            string temp = Console.ReadLine();
            Console.WriteLine("");
            cont = int.Parse(temp);
            if (cont == 1) {
                //New Entry
                var one = new Prompt();
                Entry entry = new Entry();
                entry.prompt = one.RandomPrompt();
                entry.text = Console.ReadLine();
                journal.entries.Add(entry);
            }  
            else if (cont == 2) {
                //Display current Journal
                journal.Display();
            }
            else if (cont == 3) {
                //Save Journal
                Console.Write("Enter a filename: ");
                filename = Console.ReadLine();
                files.SaveJournal(journal, filename);
            }
            else if (cont == 4) {
                //Load Journal
                Console.Write("Enter a filename to load: ");
                filename = Console.ReadLine();
                journal = files.LoadJournal(filename);
                journal.Display();
            }
            else if (cont == 5) {
                //Create a new Journal
                journal = new Journal();
                Console.WriteLine("~~~~~ New Journal created ~~~~~\n");
            }
        }
        Console.WriteLine("\"Smell ya later!\"\n- Gary Oak, 1998");
    }
}

class Prompt {
    public List<String> prompts = new List<String> {
        "What did you eat for breakfast today?",
        "Did you meet anyone new today?",
        "What's something funny that happened today?",
        "What is something cool that you saw today?",
        "What are you planning to do later today?",
        "How are you feeling in this moment?",
        "Has anything made you smile today?",
        "If you could redo something today, what would it be?"
    };
    Random randomPrompt = new Random();

    public string RandomPrompt() {
        int rand = randomPrompt.Next(prompts.Count());
        string prompt = prompts[rand];
        Console.WriteLine(prompt);
        return prompt;
    }
}

public class Entry {
    public string text;
    public string prompt;
    public string date;
    

    public Entry() {
        DateTime theCurrentTime = DateTime.Now;
        date = theCurrentTime.ToShortDateString();
        
    }
}

public class Journal {
    public List<Entry> entries = new List<Entry>();

    public void Display() {
        foreach (Entry entry in entries) {
            Console.WriteLine(entry.date);
            Console.WriteLine(entry.prompt);
            Console.WriteLine(entry.text);
        }
        Console.WriteLine("");
    }
}

public class FileManager {
    public void SaveJournal(Journal journal, string filename) {
        using (StreamWriter outputFile= new StreamWriter(filename)) {
            foreach (var entry in journal.entries) {
                string data = $"{entry.date};{entry.prompt};{entry.text}";
                outputFile.WriteLine(data);
            }
        }
    }
    public Journal LoadJournal(string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);
        Journal journal = new Journal();
        
        foreach (string line in lines) {
            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry();
            entry.date = date;
            entry.prompt = prompt;
            entry.text = text;
            journal.entries.Add(entry);
        }
        return journal;
    }
}