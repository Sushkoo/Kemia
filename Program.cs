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
            StreamWriter cw = new StreamWriter("felfedezesek.csv");

            List<ListaElem> lista = new List<ListaElem>();
            

            bool EndOfStream = true;
            while (!EndOfStream)
            {
                lista.Add();
            }

            //3.feladat
            int kemiaiElemek = lista.Count();
            Console.WriteLine($"3.feladat: Elemek száma:{kemiaiElemek}");

            //4.feladat
            int okoriFelfedezesek = lista.Where(x=> x="Ókor").Count();
            Console.WriteLine($"4.feladat: Felfedezések száma az ókorban: {okoriFelfedezesek}");

            //5.feladat
            Console.WriteLine("Kérek egy vegyjelet: ");
            foreach (var i in lista)
            {

            }
           string vegyjel=Console.ReadLine();
           string keresettElem = lista.ForEach(x => x = vegyjel);


            //6.feladat

            //7.feladat

            //8.feladat

            

        }
    }
}
