
//-------------(part 2)

using System;

enum Gender
{
    Male,
    Female
}

class Employee
{

    private int id;
    private string name;
    private double salary;
    private Gender gender;


    public int ID
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            if (value < 3000)
                salary = 3000;
            else
                salary = value;
        }
    }

    public Gender Gender
    {
        get
        {
            return gender;
        }
        set
        {
            gender = value;
        }
    }


    public Employee(int id, string name, double salary, Gender gender)
    {
        ID = id;
        Name = name;
        Salary = salary;
        Gender = gender;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Salary: {Salary}, Gender: {Gender}";
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[3];

        employees[0] = new Employee(1, "Ahmed", 3500, Gender.Male);
        employees[1] = new Employee(2, "Sara", 2500, Gender.Female);
        employees[2] = new Employee(3, "Omar", 5000, Gender.Male);

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}
