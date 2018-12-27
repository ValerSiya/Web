using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalik
{
    class Query4: abstractQuery
    {
        public override void Realization(Connection c)
        {
            Console.WriteLine("Реализация запроса 4");
            Console.Write("4.Введите название сувенира:");
            string nm = Console.ReadLine();
            Console.Write("Введите год:");
             int dt = Convert.ToInt32(Console.ReadLine());
            string sql4 = "SELECT Maker.Id, Maker.Name, Maker.Country FROM Souvenir INNER JOIN Maker on Maker.Id = Souvenir.MakerId WHERE Souvenir.Name='" + nm + "' AND YEAR(Data)=" + dt + "";
            Task(sql4, c);
            Console.ReadKey();
        }
    }
}
