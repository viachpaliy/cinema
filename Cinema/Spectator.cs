using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    enum Sex
    {
        Men,
        Women
    }
    class Spectator
    {
        private string _fio;
        private Sex _sex;
        private int _age;

        public Spectator()
        {
            _fio = "";
            _sex = Sex.Men;
            _age = -1;
        }

        public Spectator(string fio, int age, Sex sex)
        {
            _fio = fio;
            _age = age;
            _sex = sex;
        }

        string Fio {
            get { return _fio; }
            set { _fio = value; }
        }
        int Age {
            get { return _age; }
            set { _age = value; }
        }

        Sex Pol
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public void print()
        {
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("Full name ..."+Fio);
            Console.WriteLine("Age.........."+Age);
            Console.WriteLine("Sex.........."+Pol.ToString());
            Console.WriteLine("****************************************************");
        }


    }
}
