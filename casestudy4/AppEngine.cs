using System;
using System.Data.SqlClient;

namespace casestudy3
{
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public void introduce(Course course)
        {
            using (con = getCon())
            {
                cmd = new SqlCommand("insert into course values (@id, @name, @duration, @fees)", con);
                cmd.Parameters.AddWithValue("@id", course.Id);
                cmd.Parameters.AddWithValue("@name", course.Name);
                cmd.Parameters.AddWithValue("@duration", course.Duration);
                cmd.Parameters.AddWithValue("@fees", course.Fees);
                try
                {
                  cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Some error occured"+e);
                }
            }
        }

        public void register(Student student)
        {
            using (con = getCon()) 
            {
               
                cmd = new SqlCommand("insert into student values(@id, @name, @dob)", con);
                cmd.Parameters.AddWithValue("@id", student.Id);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@dob", student.Dob);
                try
                { 
                   cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Some error occured"+e);
                }
            }
        }

        internal void UpdateCourse()
        {
            throw new NotImplementedException();
        }


        public Student[] listOfStudents()
        {
            int rowsNumber = GetNoOfRows("select count(*) from student");
            Student[] s = new Student[rowsNumber];

            using (con = getCon())
            {
                try
                {
                    cmd = new SqlCommand("select * from student",con);
                    using (dr = cmd.ExecuteReader())
                    {
                        int count = 0;
                        while (dr.Read())
                        {
                            s[count] = new Student(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToDateTime(dr[2]));
                            count++;
                        }
                    }
                   
                }
                catch(Exception e)
                {  
                    Console.WriteLine("Something went wrong"+e);
                }
            }
            return s;
        }

        public Course[] listOfCourses()
        {
            int rowsNumber = GetNoOfRows("select count(*) from course");
          
            Course[] c = new Course[rowsNumber];
            using (con = getCon())
            {
                try
                {
                    cmd = new SqlCommand("select * from course", con);
                    using (dr = cmd.ExecuteReader())
                    {
                        int count = 0;
                        while (dr.Read())
                        {
                            c[count] = new Course(
                                Convert.ToInt32(dr[0]),
                                Convert.ToString(dr[1]),
                                Convert.ToDateTime(dr[2]),
                                (float)Convert.ToDecimal(dr[3])
                            );
                            
                            count++;
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong" + e);
                }
            }
            return c;
        }

        
        public void enroll(Student student, Course course)
        {

        }

        public Enroll[] listOfEnrollments()
        {
            return null;
        }

        public static SqlConnection getCon()
        {
            con = new SqlConnection("Data Source=RMGW58ZLPC0879\\SQLEXPRESS; Initial Catalog = SchoolMs; User ID = sa; Password = Temp1234");
            con.Open();
            return con;
        }

        public static int GetNoOfRows(String countCmd) 
        {
            int NoOfRows = 0;
            using (con = getCon())
            {
                cmd = new SqlCommand(countCmd,con);
                NoOfRows =(int) cmd.ExecuteScalar();
            }
            return NoOfRows;
        }
    }

}
