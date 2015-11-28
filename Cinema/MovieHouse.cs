using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class MovieHouse
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private Film[] _films;
        private Auditorium[] _auditoria;

        public void PrintAllFilms()
        {
            foreach (var film in _films)
            {
                Console.WriteLine(film);
            }
        }





    }
}
