using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class SpectatorGenerator
    {
        private string[] _familia = new[]
        {
            "Petrenko",
            "Simonenko",
            "Doroshenko",
            "Pinchuk",
            "Mosiychuk",
            "Timoshenko",
            "Gavrilyuk",
            "Boyko",
            "Vilkul",
            "Yuschenko"
        };

        private string[] _menNames = new[]
        {
            "Ivan",
            "Petro",
            "Dmytro",
            "Sergiy",
            "Olexandr",
            "Olexiy",
            "Andriy",
            "Grigoriy",
            "Georgiy",
            "Stepan"
        };

        private string[] _womenNames = new[]
        {
            "Natalia",
            "Tatyana",
            "Katerina",
            "Yana",
            "Olga",
            "Elena",
            "Valentina",
            "Irina",
            "Nina",
            "Tamara"
        };

        Random _r=new Random();

        public Spectator GetNewSpectator()
        {
            int age = _r.Next(15, 65);
            int pol = _r.Next()%2;
            Sex sex;
            if (pol == 1)
            {
                sex=Sex.Women;
            }
            else { sex=Sex.Men;}
            string f = _familia[_r.Next(0, _familia.Length)];
            string i;
            string o;
            o = _menNames[_r.Next(0, _menNames.Length)];
            if (sex == Sex.Men)
            {
                i = _menNames[_r.Next(0, _menNames.Length)];
                if (o[o.Length - 1]== 'o')
                {
                    o = o + "vych";
                }
                else
                {
                    o = o + "ovych";
                }
            }
            else
            {
                i = _womenNames[_r.Next(0, _womenNames.Length)];
                if (o[o.Length - 1] == 'o')
                {
                    o = o + "vna";
                }
                else
                {
                    o = o + "ovna";
                }
            }

            string fio = f + " " + i + " " + o;
            
            Spectator S=new Spectator(fio,age,sex);
            return S;
        }



    }
}
