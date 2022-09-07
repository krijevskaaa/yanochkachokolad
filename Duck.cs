using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck
{
    abstract class Duck
    {
        public bool c_swim;
        public string c_display;
        public static List<Duck> ducks;
        public Duck(bool swim, string display)
        {
            c_swim = swim;
            c_display = display;
        }


        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public static void performFly()
        {

        }

        public static void performQuack()
        {

        }

        public static void AddNewDuck(ref Duck  item)
        {
            
            ducks.Add(item);
            Console.WriteLine("Your duck added!");
        }

        public static void ShowList()
        {
            for (int i = 0; i < ducks.Count; i++)
            {
                Console.WriteLine(i + ". " + ducks[i].c_display);
            }
        }

        public abstract void Display();

    }
}
