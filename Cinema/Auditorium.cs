using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Auditorium
    {
        public Film CurrentFilm { get; set; }
        public int Numer { get; set; }
        private Spectator[] Viewers;

        public Spectator this[int index]
        {
            set { Viewers[index] = value; }
            get { return Viewers[index]; }

        }

        public Auditorium()
        {
            Numer = 0;
        }

        public Auditorium(int nomer, Film film, Spectator[] viewrs)
        {
            Numer = nomer;
            CurrentFilm = film;
            Viewers = viewrs;
        }

        public int GetCountOfViewers()
        {
            return Viewers.Length + 1;
        }

        public int GetCountOfWomen()
        {
            int Count = 0;
            foreach (var spectator in Viewers)
            {
                if (spectator.Pol == Sex.Women)
                {
                    Count = Count + 1;
                }
            }
            return Count;
        }

        public int GetCountOfMen()
        {
            int Count = 0;
            foreach (var spectator in Viewers)
            {
                if (spectator.Pol == Sex.Men)
                {
                    Count = Count + 1;
                }
            }
            return Count;
        }

        public override string ToString()
        {
            var str = new StringBuilder(string.Format("Numer of auditorium: {0}\nFilm: {1}\nViewers({2}):\n", Numer,CurrentFilm, Viewers.Length));
            foreach (var spectator in Viewers)
            {
                str.AppendLine(spectator.ToString());
            }
            return str.ToString();
            
        }
    }
}