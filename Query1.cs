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
    class Query1: abstractQuery
    {
        public override void Realization(Connection c)
        {
            Console.WriteLine("Реализация запроса 1");
            Console.Write("1.Введите название: ");
            string name = Console.ReadLine();
            string sql1 = "SELECT Souvenir.Id, Souvenir.Name, Souvenir.Price FROM Souvenir INNER JOIN Maker ON Maker.Id=Souvenir.MakerId  Where Maker.Name=" + "'" + name + "'";
            Task(sql1, c);
            Console.ReadKey();
        }
        
    }
}
