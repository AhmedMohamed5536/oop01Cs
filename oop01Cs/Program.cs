
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

