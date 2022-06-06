using System;


namespace casestudy3 
{
    class UserInterfaceImpl : IUserInterface
    {
        private AppEngine appEngine = new AppEngine();

        public void introduceNewCourseScreen()
        {
            
        }

        public void showAdminScreen()
        {
            Console.WriteLine("Admin Screen");
            Console.WriteLine("------------");
            Console.WriteLine("1. Add new Course");
            Console.WriteLine("2. Update Course Details");
            Console.WriteLine("3. Enroll Students");
            Console.WriteLine("4. View All Enrollments");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");
            int userChoice = Convert.ToInt32((Console.ReadLine()));
            switch (userChoice)
            {
                case 1:
                    sowAddCourseScreen();
                    break;
                case 2:
                     appEngine.UpdateCourse();
                    break;
                case 3:
                     appEngine.enroll(new Student(), new Course());
                    break;
                case 4:
                     appEngine.listOfEnrollments();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    showInvalidChoiceScreen();
                    break;

            }
        }

        

        public void showAllCoursesScreen()
        {
            Console.WriteLine("List of Courses");
            Console.WriteLine("---------------");
            foreach (Course c in new AppEngine().listOfCourses()) 
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void showAllStudentsScreen()
        {
            Console.WriteLine("List of Students");
            Console.WriteLine("----------------");
            foreach (Student s in new AppEngine().listOfStudents())
            {
                Console.WriteLine(s.ToString());
            }
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
                default:
                    showInvalidChoiceScreen();
                    break;
            }

        }

        public void showStudentRegistrationScreen()
        {
            Student student = new Student();
            Console.WriteLine("Enter Student Id:");
            student.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter Studetn DOB: ");
            student.Dob = Convert.ToDateTime(Console.ReadLine());
            appEngine.register(student);
        }

        private void sowAddCourseScreen()
        {
            Course c = new Course();
            Console.WriteLine("Enter Course Id: ");
            c.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Name: ");
            c.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Course Duration: ");
            c.Duration = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Couse Fee: ");
            c.Fees = (float)Convert.ToDecimal(Console.ReadLine());
            appEngine.introduce(c);
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
                    showStudentRegistrationScreen();
                    break;
                default:
                    showInvalidChoiceScreen();
                    break;
            }
        }

        private void showInvalidChoiceScreen()
        {
            Console.WriteLine("Invalid Chice.");
        }
    }
}
