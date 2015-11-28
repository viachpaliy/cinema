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
           Spectator S1 = new Spectator("Petrenko", 29, Sex.Men);
            SpectatorGenerator SG=new SpectatorGenerator();
            Spectator S2 = SG.GetNewSpectator();
            Spectator S3 = SG.GetNewSpectator();
            S1.print();
           S2.print();
            S3.print();
            Console.ReadKey();
        }
    }
}
