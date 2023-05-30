using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!\n");

        var test = new Assignment("Michael Munoz", "Programming");
        Console.WriteLine(test.GetSummary());
        var test2 = new MathAssignment("Michael Munoz", "Matrices", "8.2", "1-32");
        Console.WriteLine(test2.GetHomeworkList());
        var test3 = new WritingAssignment("Michael Munoz", "Greek History", "The Fall of Rome by Michael Munoz");
        Console.WriteLine(test3.GetWritingInformation());

    }
}

class Assignment {
    protected string _name;
    protected string _topic;

    public Assignment(string name, string topic) {
        _name = name;
        _topic = topic;
    }

    public string GetSummary() {
        return $"Student Name: {_name}\nTopic: {_topic}\n";
    }
}

class MathAssignment: Assignment {
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbookSection, string problems): base(name, topic) {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return $"{_name} - {_topic}\nSection {_textbookSection} Problems {_problems}\n";
    }
}

class WritingAssignment: Assignment {
    private string _title;

    public WritingAssignment(string name, string topic, string title): base(name, topic) {
        _title = title;
    }

    public string GetWritingInformation() {
        return $"{_name} - {_topic}\n{_title}\n";
    }
}