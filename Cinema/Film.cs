using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    enum Genre
    {
        Action,
        Adventure,
        Comedy,
        Drama,
        NoGenre
    }
    class Film
    {
        string Name { get; set; }
        Genre FilmGenre { get; set; }
        int Views { get; set; }
        float TicketPrice { get; set; }

      public  Film()
        {
            Name = "NoName";
            FilmGenre = Genre.NoGenre;
            Views = 0;
            TicketPrice = 0;
        }

      public  Film(string name, Genre genre, int views, int price)
        {
            Name = name;
            FilmGenre = genre;
            Views = views;
            TicketPrice = price;
        }

        public override string ToString()
        {

            var str =
                new StringBuilder(string.Format("Name: {0}\nGenre: {1}\nViews: {2}\nPrice of tickets: {3}\n", Name,
                    FilmGenre, Views, TicketPrice));
            return str.ToString();
        }
    }
}
