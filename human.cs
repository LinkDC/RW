using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    class Human
    {
        public Human()
        {
            _age = 20;
        }
        public Human(int age)
        {
            _age = age;
        }

        // Свойство Age
        public int Age
        {
            // Блок get
            get
            {
                return _age;
            }
            // Блок set
            set
            {

                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 120)
                {
                    value = 120;
                }
            }

            

        }

        protected int _age;

        public virtual void Print()
        {
            Console.WriteLine("lol");       
        }
    }
}
