using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kutyak
{

    class Program
    {
        static List<KutyaNev> KutyaNevek = new List<KutyaNev>();

        static void KutyaNevekBeolvasas()
        {
            StreamReader sr = new StreamReader("KutyaNevek.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');

                KutyaNevek.Add(new KutyaNev(
                  Convert.ToInt32(adat[0]),
                  adat[1]
                ));
            }

            sr.Close();
        }

        static void feladat3()
        {
            Console.WriteLine($"3. Feladat: Kutyanevek száma: {KutyaNevek.Count()}");
        }

        static void feladat4()
        {

        }

        static void Main(string[] args)
        {
            KutyaNevekBeolvasas();
            feladat3();

            Console.ReadKey();
        }
    }
}
