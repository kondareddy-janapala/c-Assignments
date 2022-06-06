using System;


namespace casestudy3
{
    class App
    {
        static void Main(string[] args)
        {
            // scenario1();
            // scenario2();
            // scenario3();

            new UserInterfaceImpl().showFirstScreen();
        }

        static void scenario1()
        {
            Student student = new Student(101, "konda", new DateTime(05, 23, 1997));
            Student student2 = new Student(102, "murthy", new DateTime(03, 23, 1996));
            Student student3 = new Student(103, "vv", new DateTime(12, 10, 1997));
            Student student4 = new Student(104, "sridhar", new DateTime(08, 10, 1998));

            Info info = new Info();
            Console.WriteLine("---------------");
            Console.WriteLine("Student Details: ");
            Console.WriteLine("---------------");
            info.display(student);
            info.display(student2);
            info.display(student3);
            info.display(student4);

        }

        static void scenario2()
        {
            Student[] students = {
                new Student(101, "konda", new DateTime(05, 23, 1997)),
                new Student(102, "murthy", new DateTime(03, 23, 1996)),
                new Student(103, "vv",  new DateTime(12, 10, 1997)),
                new Student(104, "sridhar", new DateTime(08, 10, 1998))
            };
            Info info = new Info();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Student Details in Array Using Foreach Loop: ");
            Console.WriteLine("-------------------------------------------");
            foreach (Student student in students)
            {
                info.display(student);
            }

        }
        static void scenario3()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter No. of students to store: ");
            int num = Int32.Parse(Console.ReadLine());
            Student[] students = new Student[num];
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter " + num + " Student Details: ");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Student Id: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Enter Student Dob: ");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());
                students[i] = new Student(id, name, dob);

            }
            Info info = new Info();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Student Details From Console, Stored in Array and Printing Using Foreach Loop: ");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (Student student in students)
            {
                info.display(student);
            }
            Console.ReadKey();
        }
    }
}
