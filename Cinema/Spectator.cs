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

        public Spectator() : this("", -1, Sex.Men)
        {
        }

        public Spectator(string fio, int age, Sex sex)
        {
            _fio = fio;
            _age = age;
            _sex = sex;
        }

      public  string Fio {
            get { return _fio; }
            set { _fio = value; }
        }
       public int Age {
            get { return _age; }
            set { _age = value; }
        }

      public  Sex Pol
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("Full name ..."+Fio);
            Console.WriteLine("Age.........."+Age);
            Console.WriteLine("Sex.........."+Pol.ToString());
            Console.WriteLine("****************************************************");
        }


        public override string ToString()
        {
            var str =
                new StringBuilder(string.Format("Full name: {0} Age: {1} Sex: {2}\n", Fio,
                    Age, Pol));
            return str.ToString();
        }
    }
}
