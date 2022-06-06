using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
