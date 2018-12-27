using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalik
{
    class Query5: abstractQuery
    {
        public override void Realization(Connection c)
        {
            Console.WriteLine("Реализация запроса 5");
            Print("Maker", c);
            Console.WriteLine("___________________________________________________");
            Print("Souvenir", c);
            Console.WriteLine(""); 
            Console.Write("5.Введите Id для удаления:"); 
            int id = Convert.ToInt32(Console.ReadLine());
            string sql5 = "DELETE  FROM Souvenir WHERE MakerId='" + id + "'; DELETE FROM Maker WHERE Id='" + id + "';";
            Task(sql5, c);
            Console.WriteLine(""); 
            Console.WriteLine("После удаления:"); 
            Print("Maker", c);
            Console.WriteLine("_______________________________________________");
            Print("Souvenir", c);
            Console.ReadKey();
        }
        public override void Task(string sql, Connection c)
        {
            using (SqlConnection connection = new SqlConnection(c.OS.Name))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
            }
        }
        public override void Print(string tb, Connection c)
        {
            using (SqlConnection connection = new SqlConnection(c.OS.Name))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("SELECT*FROM " + tb, connection);
                SqlDataReader reader = command1.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write("{0}\t", reader.GetName(i));
                Console.WriteLine();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            Console.Write("{0}\t", reader.GetValue(i));
                        Console.WriteLine();
                    }
                }
                else
                    Console.WriteLine("Table is empty");
            }

        }
    }
}
