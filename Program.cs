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
            c.ConnectToBD();
            Query1 q1 = new Query1();
            q1.Realization(c);
            Console.WriteLine();
            Query2 q2 = new Query2();
            q2.Realization(c);
            Console.WriteLine();
            Query3 q3 = new Query3();
            q3.Realization(c);
            Console.WriteLine();
            Query4 q4 = new Query4();
            q4.Realization(c);
            Console.WriteLine();
            Query5 q5 = new Query5();
            q5.Realization(c);
            Console.WriteLine();

            }

        }
    }
