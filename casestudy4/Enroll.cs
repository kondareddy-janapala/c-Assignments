using System;

namespace casestudy3
{
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public DateTime EnrollmentDate { get => enrollmentDate; set => enrollmentDate = value; }
        internal Student Student { get => student; set => student = value; }
        internal Course Course { get => course; set => course = value; }

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

        

        public override string ToString()
        {
            return "Student: " + this.student.ToString() + " Course: " + this.course.ToString() + " EnrollmentDate: " + this.enrollmentDate.ToString();
        }
    }
}
