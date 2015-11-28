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
            Spectator[] S2 =new Spectator[100];

            for (int i = 0; i < S2.Length; i++)
            {
                S2[i] = SG.GetNewSpectator();
            }
           
            var F1 = new Film("Film", Genre.Action, 100, 50);
            var A1 = new Auditorium(1, F1, S2);
            Console.WriteLine(A1);
            Console.ReadKey();
        }
    }
}
