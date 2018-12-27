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
    class Query3:abstractQuery
    {
        public override void Realization(Connection c)
        {
            Console.WriteLine("Реализация запроса 3");
            Console.Write("3.Введите цену: ");
            int price = Convert.ToInt32(Console.ReadLine());
            string sql3 = "SELECT Maker.Id, Maker.Name, Maker.Country from Souvenir join Maker on Maker.Id = Souvenir.MakerId WHERE Price <" + price + " group by Maker.Name, Country, Maker.Id;";
            Task(sql3, c);
            Console.ReadKey();
        }
    
    }
}
