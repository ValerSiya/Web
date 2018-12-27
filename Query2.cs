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
    class Query2: abstractQuery
    {
        public override void Realization(Connection c)
        {
            Console.WriteLine("Реализация запроса 2");
            Console.Write("2.Введите страну: ");
            string country = Console.ReadLine();
            string sql2 = "SELECT Souvenir.Id, Souvenir.Name, Souvenir.Price FROM Souvenir INNER JOIN Maker ON Maker.Id=Souvenir.MakerId  Where Maker.Country=" + "'" + country + "'";
            Task(sql2, c);
            Console.ReadKey();
        }
    }
}
