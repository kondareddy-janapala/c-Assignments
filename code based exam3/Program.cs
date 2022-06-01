using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BasicADO
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            //insertEmp(1001, "konda", 26000.00f, "C");
            insertEmp(1002, "murthy", 36000.00f, "P");



        }
        public static void insertEmp(int no, string name, float sal, String type) {
            using (con = getCon()) {
                SqlCommand command = new SqlCommand("insertemp", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@empno", SqlDbType.Int).Value = no;
                command.Parameters.AddWithValue("@empname", SqlDbType.NVarChar).Value = name;
                command.Parameters.AddWithValue("@empsal", SqlDbType.Decimal).Value = sal;
                command.Parameters.AddWithValue("@emptype", SqlDbType.NVarChar).Value = type;
                command.ExecuteNonQuery();
                con.Close();
            }
        }
        public static SqlConnection getCon()
        {
            con = new SqlConnection("Data Source=RMGW58ZLPC0879\\SQLEXPRESS; Initial Catalog = ZensarDB; User ID = sa; Password = Temp1234");
            //new SqlConnection("data source=DESKTOP-PU8R89M\\BRSQL;Initial Catalog=ZensarDB;" +
            //user id=sa; password=   ");
            con.Open();
            return con;
        }
    }
}