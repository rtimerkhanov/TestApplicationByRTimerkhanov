using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationByRTimerkhanov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Здравствуй, дорогой друг!
Давай я продемонстрирую тебе свой сервис TrueTweetStatisticsNagibator666.
Желаешь сначала войти в свой аккаунт Twitter, чтобы иметь возможность публиковать результаты?
1. Да, конечно.
2. Нет. Возможно, позже.");

            bool isOK = false;
            int choice = 0;

            do
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1 || choice == 2)
                    {
                        isOK = true;
                    }
                    else throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n\nВероятно, ты допустил ошибку при вводе. Попробуй еще раз, у тебя все получится :)\n");
                    Console.WriteLine(@"Желаешь сначала войти в свой аккаунт Twitter, чтобы иметь возможность публиковать результаты?
1. Да, конечно.
2. Нет. Возможно, позже.");
                } while (isOK == false);

            switch (choice)
            {
                case 1: break;
                case 2: break;
            }

        }

        static void logIn()
        {

        }



    }
}
