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
    abstract class abstractQuery
    {
        string tb;
        public void CreateQuery(string sql, Connection c)
        {
            Task(sql, c);
            Realization(c);
            Print(tb, c);
        }

        public virtual void Print(string tb, Connection c) { }
        public abstract void Realization(Connection c);
        public virtual void Task(string sql, Connection c)
        {
            using (SqlConnection connection = new SqlConnection(c.OS.Name))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataColumn col in ds.Tables[0].Columns)
                    Console.Write("{0}\t", col.ColumnName);
                Console.WriteLine();
                foreach (DataRow row in ds.Tables[0].Rows)
                    Console.WriteLine("{0}\t {1} {2}", row[0], row[1], row[2]);
                connection.Close();
            }
        }

    }
}
