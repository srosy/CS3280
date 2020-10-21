using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Data Source=localhost;Initial Catalog=CS3280;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                var command = new SqlCommand("SELECT * FROM DEPARTMENTS WHERE LOCATION = 'Ogden';", conn);
                command.CommandType = CommandType.Text;

                var adapter = new SqlDataAdapter(); 
                adapter.SelectCommand = command;
                var ds = new DataSet("CS3280");
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Console.Write(row["DeptID"] + "\t");
                    Console.Write(row[1] + "\t");
                    Console.WriteLine(row[2]);
                }


                Console.WriteLine();
            }
        }
    }
}
