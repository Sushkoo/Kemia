using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat

            //List<ListaElem> lista = new List<ListaElem>();
           

            List<string> sorok = File.ReadAllLines("felfedezesek.csv").Skip(0).ToList();

            //3.feladat
            int kemiaiElemek = sorok.Count();
            Console.WriteLine($"3.feladat: Elemek száma:{kemiaiElemek}");

            //4.feladat
            int okoriFelfedezesek = sorok.Where(x=> x="Ókor").Count();
            Console.WriteLine($"4.feladat: Felfedezések száma az ókorban: {okoriFelfedezesek}");

            //5.feladat
            Console.WriteLine("Kérek egy vegyjelet: ");
           string vegyjel=Console.ReadLine();
           
           string keresettElem = sorok.ForEach(x => x = vegyjel);


            //6.feladat

            //7.feladat

            //8.feladat

            

        }
    }
}
