
//------------------------(Part 1 (Ex1)

//using System;

//struct Point
//{
//    public double X;
//    public double Y;
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1, p2;

//        Console.Write("X1: "); p1.X = double.Parse(Console.ReadLine());
//        Console.Write("Y1: "); p1.Y = double.Parse(Console.ReadLine());
//        Console.Write("X2: "); p2.X = double.Parse(Console.ReadLine());
//        Console.Write("Y2: "); p2.Y = double.Parse(Console.ReadLine());

//        double dx = p2.X - p1.X;
//        double dy = p2.Y - p1.Y;
//        double distance = Math.Sqrt(dx * dx + dy * dy);

//        Console.WriteLine("Distance = " + distance);
//    }
//}


//-----------------------------------------------------------------
//-------------((part 1  EX2))
//using System;

//struct Person
//{
//    public string Name;
//    public int Age;
//}

//class Program
//{
//    static void Main()
//    {
//        Person[] people = new Person[3];

//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write("Name: ");
//            people[i].Name = Console.ReadLine();

//            Console.Write("Age: ");
//            people[i].Age = int.Parse(Console.ReadLine());
//        }

//        Person oldest = people[0];

//        for (int i = 1; i < 3; i++)
//        {
//            if (people[i].Age > oldest.Age)
//                oldest = people[i];
//        }

//        Console.WriteLine("Oldest: " + oldest.Name + ", Age: " + oldest.Age);
//    }
//}

//------------------------------------------------------------------
//-------------(part 2)

//using System;

//enum Gender
//{
//    Male,
//    Female
//}

//class Employee
//{

//    private int id;
//    private string name;
//    private double salary;
//    private Gender gender;


//    public int ID
//    {
//        get
//        {
//            return id;
//        }
//        set
//        {
//            id = value;
//        }
//    }

//    public string Name
//    {
//        get
//        {
//            return name;
//        }
//        set
//        {
//            name = value;
//        }
//    }

//    public double Salary
//    {
//        get
//        {
//            return salary;
//        }
//        set
//        {
//            if (value < 3000)
//                salary = 3000;
//            else
//                salary = value;
//        }
//    }

//    public Gender Gender
//    {
//        get
//        {
//            return gender;
//        }
//        set
//        {
//            gender = value;
//        }
//    }


//    public Employee(int id, string name, double salary, Gender gender)
//    {
//        ID = id;
//        Name = name;
//        Salary = salary;
//        Gender = gender;
//    }

//    public override string ToString()
//    {
//        return $"ID: {ID}, Name: {Name}, Salary: {Salary}, Gender: {Gender}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee[] employees = new Employee[3];

//        employees[0] = new Employee(1, "Ahmed", 3500, Gender.Male);
//        employees[1] = new Employee(2, "Sara", 2500, Gender.Female);
//        employees[2] = new Employee(3, "Omar", 5000, Gender.Male);

//        foreach (Employee emp in employees)
//        {
//            Console.WriteLine(emp);
//        }
//    }
//}

