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
    class Program
    {
       
        static void Main(string[] args)
        {
            
            /* С помощью ридера
             Connection c = new Connection();
            using (SqlConnection connection = new SqlConnection(c.connectionString))
            {
                connection.Open();
                Console.Write("Введите название: ");
                string name = Console.ReadLine();
                SqlCommand command1 = new SqlCommand("SELECT  Souvenir.Name, Souvenir.Data, Souvenir.Price FROM Souvenir INNER JOIN Maker ON Maker.Id=Souvenir.MakerId  Where Maker.Name=" + "'" + name + "'", connection);
                SqlDataReader reader1 = command1.ExecuteReader();
                Show(reader1);
                connection.Close();   
            }*/
            Connection c = new Connection();
            c.Launch();
            Console.Write("1.Введите название: ");
            string name = Console.ReadLine();
            string sql1 = "SELECT  Souvenir.Name, Souvenir.Data, Souvenir.Price FROM Souvenir INNER JOIN Maker ON Maker.Id=Souvenir.MakerId  Where Maker.Name=" + "'" + name + "'";
            Task2(sql1, c);
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("2.Введите страну: ");
            string country = Console.ReadLine();
            string sql2 = "SELECT * FROM Souvenir INNER JOIN Maker ON Maker.Id=Souvenir.MakerId  Where Maker.Country=" + "'" + country + "'";
            Task2(sql2, c);
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("3.Введите цену: ");
            int price = Convert.ToInt32(Console.ReadLine());
            string sql3 = "SELECT Maker.Name, Maker.Country from Souvenir join Maker on Maker.Id = Souvenir.MakerId WHERE Price <" + price + " group by Maker.Name, Country;";
            Task2(sql3, c);
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("4.Введите название сувенира:");
            string nm = Console.ReadLine();
            Console.Write("Введите дату(типа 2018-02-02):");
            string dt = Console.ReadLine();
            string sql4 = "SELECT Maker.Name, Maker.Country FROM Souvenir INNER JOIN Maker on Maker.Id = Souvenir.MakerId WHERE Souvenir.Name='"+nm+"' AND Data='"+dt+"'";
            Task2(sql4, c);

            Console.Write("5.Введите Id для удаления:");
            int id = Convert.ToInt32(Console.ReadLine());
            string sql5 = "DELETE  FROM Souvenir WHERE MakerId='" + id + "'; DELETE FROM Maker WHERE Id='" + id + "';";
                 Taskdel(sql5, c);

            }


        static void Show( SqlDataReader reader)
        {
            Console.Write("No.  ");
            for (int i = 0; i < reader.FieldCount; i++)
                Console.Write(reader.GetName(i) + "           ");
            Console.WriteLine();
            if (reader.HasRows)
            {
                int index = 0;
                while (reader.Read())
                {
                    index++;
                    Console.Write(index + ".");
                    for (int i = 0; i < reader.FieldCount; i++)
                        Console.Write("  " + reader.GetValue(i));
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Table is empty");
        }



        static void Task2(string sql, Connection c)
        {
            using (SqlConnection connection = new SqlConnection(c.OS.Name))
            {
                connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
                Console.WriteLine("{0} {1}", row[0], row[1]);
            connection.Close();
            }
            
        }
        static void Taskdel(string sql, Connection c)
        {
            using (SqlConnection connection = new SqlConnection(c.OS.Name))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Console.WriteLine("Deleted!");
                connection.Close();
            }

        }

        }
    }
