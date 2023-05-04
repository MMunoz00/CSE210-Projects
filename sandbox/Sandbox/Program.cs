using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        // object
        // instance
        
        var mihael = new Person("Mihael", "Keele");
        var nate = new Person("Nate", "River");

        mihael.Talk();
        nate.Talk();
        mihael.FullName();
        nate.FullName();

    }
}
// classification

class Person {

    // attributes
    // properties

    string firstName;
    string lastName;
    // string fullName;

    // constructor

    public Person(string fn, string ln) {
        firstName = fn;
        lastName = ln;
    }

    // behaviors
    // method

    public void Breathe() {
        Console.WriteLine("Breathing");
    }

    public void Walk() {
        Console.WriteLine("Walking");
    }

    public void Talk() {
    //     Console.WriteLine($"Hi! My name is {firstName} {lastName}.");
        Console.WriteLine(FullName());
    }

    public string FullName() {
        // fullName = firstName + "" + lastName;
        // return fullName;
        return $"{firstName} {lastName}";
    }
}