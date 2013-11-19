using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace testEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            using (var db = new DB.MSSQL.courseMSSQLEntities())
            {
                foreach (var i in db.Courses)
                {
                    Console.WriteLine(i.NAME);
                }
            }
            sw1.Stop();
            Console.WriteLine("Using {0} miniseconds.", sw1.ElapsedMilliseconds);

            sw1.Reset();
            sw1.Start();
            using (var db = new DB.MySQL.courseMySQLEntities())
            {
                foreach (var i in db.courses)
                {
                    Console.WriteLine(i.NAME);
                }
            }
            
            sw1.Stop();
            Console.WriteLine("Using {0} miniseconds.", sw1.ElapsedMilliseconds);

        }
    }
}
