using System;

namespace casestudy3
{
    class Course
    {
        private int id;
        private String name;
        private DateTime duration;
        private float fees;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Duration { get => duration; set => duration = value; }
        public float Fees { get => fees; set => fees = value; }

        public Course()
        { 
        }
        public Course(int id, string name, DateTime duration, float fees)
        {
            this.Id = id;
            this.Name = name;
            this.Duration = duration;
            this.Fees = fees;
        }

     

        public override string ToString()
        {
            return "Id: " + this.Id + ", Name: " + this.Name + ", Duration: " + this.Duration + ", Fees: " + this.fees;
        }
    }
}
