using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy3
{
    class Student
    {
        private int id;
        private string name;
        private DateTime dob;

        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public int Id { get => id; set => id = value; }

        public Student(int id, string name, DateTime dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        public Student()
        { 
        
        }

        public override string ToString()
        {
            return "Student Id: " + this.Id + ", Student Name: " + this.Name + ", Date of Birth: " + this.Dob ;
        }
    }
}
