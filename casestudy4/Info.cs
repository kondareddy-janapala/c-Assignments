using System;


namespace casestudy3
{
    class Info
    {
        public void display(Student student)
        {
            Console.WriteLine(student.ToString());
        }

        public void display(Course course)
        {
            Console.WriteLine(course.ToString());
        }

        public void display(Enroll enroll)
        {
            Console.WriteLine(enroll.ToString());
        }
    }
}
