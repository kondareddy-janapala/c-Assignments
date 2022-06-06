using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy3 
{
    class UserInterfaceImpl : IUserInterface
    {
        public void introduceNewCourseScreen()
        {
            
        }

        public void showAdminScreen()
        {

        }

        public void showAllCoursesScreen()
        {
           
        }

        public void showAllStudentsScreen()
        {
            
        }

        public void showFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
            }

        }

        public void showStudentRegistrationScreen()
        {
           
        }

        public void showStudentScreen()
        {
            Console.WriteLine("Student Screen");
            Console.WriteLine("--------------");
            Console.WriteLine("1. View all Students");
            Console.WriteLine("2. View all Courses");
            Console.WriteLine("3. New Student");
            Console.WriteLine("Enter 1, 2 or 3");

            int option = Convert.ToInt32((Console.ReadLine()));
            switch (option)
            {
                case 1:
                    showAllStudentsScreen();
                    break;
                case 2:
                    showAllCoursesScreen();
                    break;
                case 3:
                    Console.WriteLine("Enter Student Number: ");
                    new AppEngine().register(GetStudentDetails());
                    break;
                    

            }
        }
        private static Student GetStudentDetails() 
        {
            Student student = new Student();
            Console.WriteLine("Enter Student Id:");
            student.Id =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter Studetn DOB: ");
            student.Dob = Convert.ToDateTime(Console.ReadLine());
            return student;
        }
    }
}
