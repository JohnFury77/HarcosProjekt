using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Harcos> harcosok; 
            Harcos PwnMaster = new Harcos("PwnMaster", 1);
            harcosok.Add(PwnMaster);
            Console.WriteLine(PwnMaster);
            Console.ReadKey();

            StringReader sr = new StringReader("");

        }
    }
}
