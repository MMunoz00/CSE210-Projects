using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        var personOne = new Person("Luke Skywalker");
        var byuiPerson = new BYUIPerson("Obi-Wan Kenobi", "1");
        var studentOne = new Student("Darth Vader", "2", "The Dark Side of the Force");
    }
}

class Person {
    protected string _name;

    public Person(string name) {
        _name = name;
    }
}

class BYUIPerson: Person {
    protected string _iNumber;

    public BYUIPerson(string name, string iNumber) : base(name) {
        _iNumber = iNumber;
    }
}

class Student: BYUIPerson {
    private string _major;

    public Student(string name, string iNumber, string major): base(name, iNumber) {
        _major = major;
    }
}

class Teacher: BYUIPerson {
    private string _department;

    public Teacher(string name, string iNumber, string department): base(name, iNumber) {
        _department = department;
    }
}