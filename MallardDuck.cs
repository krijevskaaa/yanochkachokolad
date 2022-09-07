using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class MallardDuck : Duck
    {
        public MallardDuck(bool swim, string display) : base(swim, display) { }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallar Duck");
        }
    }
}
