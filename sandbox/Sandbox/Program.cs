using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    
        var hourly = new HourlyEmployee(1000, "Enriqo Fermi", 14);
        var salary = new SalaryEmployee(90000, "Robert Oppenheimer", 14);
        
        var employees = new List<Employee> {hourly, salary};

        foreach (var employee in employees) {
            Console.WriteLine(employee._name);
            Console.WriteLine(employee.PayPeriodWages());
        }
    }
}

class Employee {
    public string _name;
    protected double _payPeriodLength;

    public Employee(string name, int payPeriodLength) {
        _name = name;
        _payPeriodLength = payPeriodLength;
    }

    virtual public double PayPeriodWages() {
        return 0;
    }
}

class HourlyEmployee: Employee {
    private double _rate;

    public HourlyEmployee(double rate, string name, int payPeriodLength): base(name, payPeriodLength) {
        _rate = rate;
    }

    public override double PayPeriodWages() {
        return _rate * 8 * _payPeriodLength;
    }
}

class SalaryEmployee: Employee {
    private double _annualRate;

    public SalaryEmployee(double annualRate, string name, int payPeriodLength): base(name, payPeriodLength) {
        _annualRate = annualRate;
    }

    public override double PayPeriodWages() {
        return ((_payPeriodLength / 365) * _annualRate);
    }
}