using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop04 World!\n");
        int choice = 1;

        while (choice != 0) {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  0. Quit Program");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1) {
                BreathingActivity breathe = new BreathingActivity();
            }            
            if (choice == 2) {
                ReflectingActivity reflect = new ReflectingActivity();
            }
            if (choice == 3) {
                ListingActivity list = new ListingActivity();
            }
            
        }

        Console.Write("Thanks for using this program! :)");

    }

}

class Activity {
    protected string startMessage;
    protected string activityDescription;
    protected int duration = 0;
    protected int pauseDuration = 3;
    protected string beginMessage = "Get ready...  ";
    protected string endMessage = "Congrats, you've completed the activity!";

    protected void StartActivity() {
        ShowSpinner(pauseDuration);
        Console.WriteLine(startMessage+"\n");
        Console.WriteLine(activityDescription);
        Console.Write("How long in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Clear();
        Console.Write(beginMessage);
        ShowSpinner(pauseDuration);
        Console.Clear();
    }

    protected void EndActivity() {
        Console.Write(endMessage);
        Thread.Sleep(4000);
        Console.Clear();
    }

    protected void CountDown(int duration) {
        int currentValue = duration;

        while (currentValue > 0) {
            Console.Write(currentValue);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            currentValue--;
        }
    }

    protected void ShowSpinner (int duration) {
       List<string> animations = new List<string> {
        "-",
        "\\",
        "|",
        "/",
       };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;
        // Console.Write("\nLoading ");
        while(DateTime.Now < endTime) {
            string frame = animations[animationIndex];
            Console.Write(frame);

            Thread.Sleep(100);
            Console.Write("\b \b");

            animationIndex++;
            if (animationIndex >= animations.Count()) {
                animationIndex = 0;
            }
        }
        Console.Clear();
    }
}

class BreathingActivity: Activity {
    public BreathingActivity() {
        startMessage = "Welcome to the Breathing Activity!";
        activityDescription = "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.\n";
    
        int breatheInDuration = 4;
        int breatheOutDuration = 6;
        
        StartActivity();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (futureTime > DateTime.Now) {
            Console.Write("Breathe In    ");
            CountDown(breatheInDuration);
            Console.Clear();

            Console.Write("Breathe Out   ");
            CountDown(breatheOutDuration);
            Console.Clear();
        }

        EndActivity();
    }

}

class ReflectingActivity: Activity {

    private List<string> _reflectPrompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string _reflectPrompt;
    private List<string> _reflectQuestions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your facorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private Random _random = new Random();

    public ReflectingActivity() {
        startMessage = "Welcome to the Reflecting Activity!";
        activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n";

        int _numPrompt = _random.Next(0, _reflectPrompts.Count() - 1);
        _reflectPrompt = _reflectPrompts[_numPrompt];

        StartActivity();
        pauseDuration = 7;

        Console.WriteLine(_reflectPrompt);
        Thread.Sleep(5000);
        Console.Clear();

        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while ((futureTime > DateTime.Now) & i < _reflectQuestions.Count()) {

            Console.WriteLine(_reflectQuestions[i]);
            ShowSpinner(pauseDuration);
            i++;

        }

        EndActivity();
    }

}

class ListingActivity: Activity {

    private List<string> _listingPrompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private string _listingPrompt;
    private Random _random = new Random();

    public ListingActivity() {
        startMessage = "Welcome to the Listing Activity!";
        activityDescription = "This activity will help you reflect on the good things in your life by having you list\nas many things as you can in a certain area.\n";
        int _numQuestion = _random.Next(0, _listingPrompts.Count() - 1);
        _listingPrompt = _listingPrompts[_numQuestion];
        
        StartActivity();
        pauseDuration = 7;

        Console.Write(_listingPrompt+"   ");
        CountDown(10);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Console.ReadLine();
        Console.WriteLine("\nKeep going!\n");
        while(futureTime > DateTime.Now) {
            Console.ReadLine();
        }
        Console.WriteLine();
        EndActivity();
    }
}