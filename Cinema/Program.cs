using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SpectatorGenerator SG=new SpectatorGenerator();
            Spectator S2 = SG.GetNewSpectator();
           
           S2.Print();
            var F1 = new Film("Film", Genre.Action, 100, 50);
            Console.WriteLine(F1);
            Console.ReadKey();
        }
    }
}
