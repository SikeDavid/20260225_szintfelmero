using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> civilian = new List<Citizen>();
            FileStream fs = new FileStream("drink.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine(); // Az elso sort atugorja
            int id = 1;
            while(!sr.EndOfStream)
            {
                Citizen c = new Citizen(sr.ReadLine());
                c.CitizenID1 = id;
                civilian.Add(c);
                id++;
            }
            sr.Close();
            fs.Close();

            void taskNumberFive()
            {
                Console.WriteLine("5. feladat");
                Console.WriteLine("");
                for (int i = 0; i < 5; i++)
                {
                    civilian[i].citizens();
                }
            }

            void taskNUmberSix()
            {

            }

            void taskNumberSeven(string filename)
            {
                FileStream fr = new FileStream(filename, FileMode.Create);
                StreamWriter sw = new StreamWriter(fr);
                for (int i = 0; i < civilian.Count; i++)
                {
                    if (civilian[i].Age1 >= 18 && civilian[i].Age1 <= 65 && civilian[i].Group.PopulationGroupName1 == "Asian" && civilian[i].Drinking1 == "Yes")
                    {
                        sw.WriteLine($"{civilian[i].Age1};{civilian[i].State1};{civilian[i].SchoolDropout1}");
                        //Console.WriteLine($"{civilian[i].Age1};{civilian[i].State1};{civilian[i].SchoolDropout1}");
                    }
                }
                sw.Close();
                fr.Close();
                Console.WriteLine($"File save success: {filename}");
            }

            taskNumberFive();

            taskNumberSeven("asian.txt");
            // Console.WriteLine($"sikeres adatbeolvasas: {civilian.Count}");
            Console.ReadKey(); // Hogy ne zarja be a console ablakot!
        }
    }
}
