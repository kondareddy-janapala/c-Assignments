using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    class Student 
    {
        private int id;
        private string name;
        private string dob;

        public Student(int id, string name, string dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        public string Name { get => name; set => name = value; }
        public string Dob { get => dob; set => dob = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return "Student[id: " + this.Id + ",name: " + this.Name + ",dob: " + this.Dob+"]";
        }

    }
    
    class Course 
    {
        private int id;
        private String name;
        private DateTime duration;
        private float fees;

        public Course(int id, string name, DateTime duration, float fees)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Duration { get => duration; set => duration = value; }
        public float Fees { get => fees; set => fees = value; }

        public override string ToString()
        {
            return "Course[id: "+this.Id+",name: "+this.Name+",duration: "+this.duration+",fees: "+this.duration+"]";
        }
    }
    
    class Info
    {
        public void display(Student student)
        {
            Console.WriteLine("Student Id: "+ student.Id+ ", Student Name: "+ student.Name+ ", Student DOB: "+ student.Dob);
        }
    }

    class App
    {
        
        static void Main(string[] args)
        {
            scenario1();
            scenario2();
            scenario3();

        }

        static void scenario1() 
        {
            Student student = new Student(101, "konda", "23/05/1997");
            Student student2 = new Student(102, "murthy", "23/03/1996");
            Student student3 = new Student(103, "vv", "10/12/1997");
            Student student4 = new Student(104, "sridhar", "16/08/1998");

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
                new Student(101, "konda", "23/05/1997"),
                new Student(102, "murthy", "23/03/1996"),
                new Student(103, "vv", "10/12/1997"),
                new Student(104, "sridhar", "16/08/1998")
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
            for (int i = 0; i<num; i++)
            {
                Console.WriteLine("Enter Student Id: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Enter Student Dob: ");
                String dob = Console.ReadLine();
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
