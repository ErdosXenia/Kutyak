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
        static List<KutyaFajta> KutyaFajtak = new List<KutyaFajta>();
        static List<Kutya> KutyaLista = new List<Kutya>();

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

        static void KutyaFajtakBeolvasas()
        {
            StreamReader sr = new StreamReader("KutyaFajtak.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');

                KutyaFajtak.Add(new KutyaFajta(Convert.ToInt32(adat[0]), adat[1], adat[2]
                ));
            }

            sr.Close();
        }

        static void KutyaBeolvasas()
        {
            StreamReader sr = new StreamReader("Kutyak.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');

                KutyaLista.Add(new Kutya(Convert.ToInt32(adat[0]), Convert.ToInt32(adat[1]), 
                    Convert.ToInt32(adat[2]), Convert.ToInt32(adat[3]), adat[4]));
            }

            sr.Close();
        }

        static void Main(string[] args)
        {
            KutyaNevekBeolvasas();
            feladat3();
            KutyaFajtakBeolvasas();
            KutyaBeolvasas();

           
            Console.ReadKey();
        }
    }
}
