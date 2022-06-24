using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int state ;
            string stopWord = "exit";
            string waitingInputWord = "";
            Console.WriteLine("1.Изменить размер по x. \n2.Изменить размер по y.\n3.Изменить цвет шрифта.\n4.Изменить фон.\n5.Очистить консоль .");
            Console.WriteLine("Для выхода напишите 'exit' ");

            while (waitingInputWord != stopWord)
            {
                Console.WriteLine("Введите 'продолжить' ");
                waitingInputWord = Console.ReadLine().ToLower().Trim();

                if(waitingInputWord == stopWord)
                {
                    break;
                }

                Console.WriteLine("Выберите вариант:");
                state = int.Parse(Console.ReadLine());

                switch (state)
                {
                    case 1:
                        Console.WriteLine("Введите X");
                        Console.WindowWidth = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Введите Y");
                        Console.WindowHeight = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("1.Желтый.\n2.Синий.\n3.Красный.\n4.Зеленый.");
                        Console.WriteLine("Выберите вариант:");
                        int chooseForegroundColor = int.Parse(Console.ReadLine());

                        switch(chooseForegroundColor)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("1.Желтый.\n2.Синий.\n3.Красный.\n4.Зеленый.");
                        Console.WriteLine("Выберите вариант:");
                        int chooseBackgroundColor = int.Parse(Console.ReadLine());

                        switch (chooseBackgroundColor)
                        {
                            case 1:
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            case 2:
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            case 3:
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case 4:
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                        }
                        break;
                    case 5:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
