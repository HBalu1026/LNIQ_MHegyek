using System;
using System.Linq;
using ConsoleApp5;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HegyCsucs> list = new List<HegyCsucs>();
            string fajlNev = "hegyekMo.tyt";
            StreamReader sr = new StreamReader(fajlNev);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                HegyCsucs elem = new HegyCsucs(sor.Split(";")[0], sor.Split(";")[1], Convert.ToInt32(sor.Split(";")[2]));
                list.Add(elem);
            }
            sr.Close();

            //3
            Console.WriteLine("Hegycsúcsok száma: " + list.Count() + "db");

            //4
            double ossz = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                ossz += list[i].Magassag;
            }

            Console.WriteLine("Hegycsúcsok átlagos magassága: " + ossz / list.Count() + "m");
        }
    }
}