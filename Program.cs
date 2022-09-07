using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            Duck duck;
            Console.WriteLine("      Меню      \n" +
                              "1. Добавить новую утку    \n" +
                              "2. Показать уток          \n" +
                              "3. Настройки              \n" +
                              "4. Завершить работу         ");
            Console.WriteLine("Enter your choise: ");
            selection = Convert.ToInt32( Console.ReadLine());
            switch (selection)
            { 
                case 1:
                    {
                        Console.WriteLine("Enter kind of your duck");
                        string display = Console.ReadLine();
                        Console.WriteLine("Can your duck swim?");
                        bool swim = Convert.ToBoolean(Console.ReadLine());
                        duck = new MallardDuck(swim, display);
                        Duck.AddNewDuck(ref duck);

                        break;
                    }
                case 2:
                    {
                        Duck.ShowList();
                        break;
                    }


            }
        }
    }
}
