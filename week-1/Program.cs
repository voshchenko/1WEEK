using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int worknumber;
            do
            {
                Console.Write("Введите номер задания 1-16 \n");
                worknumber = Convert.ToInt32(Console.ReadLine());

                switch (worknumber)
                {
                    case 1:
                        {
                            Console.Write("Задание 1 \n");
                            Console.Write("Введите два числа \n");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            if (n1 > n2)
                            {
                                Console.WriteLine(n1);
                            }
                            else
                            {
                                Console.WriteLine(n2);
                            }
                            break;

                        }
                    case 2:
                        {
                            Console.Write("Задание 2 \n");
                            Console.Write("Введите слово «мяу» или слово «гав» \n"); //Пользователь вводит слово «мяу» или слово «гав»
                            string n1 = Convert.ToString(Console.ReadLine());
                            if (n1 == "мяу")
                            {
                                Console.WriteLine("Покорми кота \n");
                            }
                            else if (n1 == "гав")
                            {
                                Console.WriteLine("Покорми собаку \n");
                            }
                            else
                            {
                                Console.WriteLine("Тебе пора погулять \n");
                            }
                            break;

                        }
                    case 3:
                        {
                            Console.Write("Задание 3 \n");
                            Console.Write("Введите номер месяца \n");
                            int num = Convert.ToInt32(Console.ReadLine());
                            if (num == 1 ^ num == 2 ^ num == 12)
                                Console.Write("Зима \n");
                            else if (num == 3 ^ num == 4 ^ num == 5)
                                Console.WriteLine("Весна \n");
                            else if (num == 6 ^ num == 7 ^ num == 8)
                                Console.WriteLine("Лето \n");
                            else if (num == 9 ^ num == 10 ^ num == 11)
                                Console.WriteLine("Осень \n");
                            else
                                Console.WriteLine("Такого месяца нет \n");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Задание 5 \n");
                            Console.Write("Введите номер недели \n");
                            int n= Convert.ToInt32(Console.ReadLine()); ;
                            switch (n)
                            {
                                case 1:
                                    Console.WriteLine("Понедельник");
                                    break;
                                case 2:
                                    Console.WriteLine("Вторник");
                                    break;
                                case 3:
                                    Console.WriteLine( "Среда");
                                    break;
                                case 4:
                                    Console.WriteLine("Четвер");
                                    break;
                                case 5:
                                    Console.WriteLine("Пятница");
                                    break;
                                case 6:
                                    Console.WriteLine("Суббота");
                                    break;
                                case 7:
                                    Console.WriteLine("Воскресенье");
                                    break;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Задание 4 \n");
                            Console.Write("Введите 0 или 1 \n");
                            int num = Convert.ToInt32(Console.ReadLine());
                            if (num == 1)
                                Console.Write("Хорошо \n");
                            else
                                Console.WriteLine("Плохо \n");

                            break;
                        }
                    case 6:
                        {
                            int price;
                            Console.Write("Задание 6 \n");
                            Console.Write("Введите колличество км \n");
                            int km = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите простой \n");
                            int pr = Convert.ToInt32(Console.ReadLine());
                            if (km < 5)
                                price = 20 + pr;
                            else
                                price = 20 + (km - 5) * 3 + pr;
                            Console.WriteLine("Цена  {0}", price);

                            break; 
                        }
                    case 7:
                        {
                            Console.Write("Задание 7 \n");
                            Console.Write("Введите число \n");
                            int num = Convert.ToInt32(Console.ReadLine());
                            if (num > 1)
                            {
                                for (int i = 2; i < num; i++)
                                {
                                    if (num % i == 0)
                                    {
                                        Console.Write("Непростое число \n");
                                        break;
                                    }
                                    else
                                        Console.Write("Простое число \n");
                                    break;
                                }
                                
                            }
                            break;
                        }
                    case 8:
                        {
                            Random rnd = new Random();
                            Console.Write("Задание 8 \n");
                            Console.Write("Введите cтавку \n");
                            int n = Convert.ToInt32(Console.ReadLine());
                            int number = rnd.Next(1, 13);
                            if (number < 6)
                            {
                                Console.Write($"вы проиграли {number} очков\n");
                            }
                            else if (number < 9 && number > 5)
                            {
                                Console.Write($"{number} очков, вы получвете свою ставку {n}\n");
                            }
                            else if (number < 12 && number > 8)
                            {
                                n = n * 2;
                                Console.Write($"{number} очков, вы получвете ставку*2 {n}\n");
                            }
                            else
                            {
                                n = n * 10;
                                Console.Write($"{number} очков, вы получвете ставку*10 {n}\n");
                            }
                            break;
                        }
                    case 9:
                        {
                            Console.Write("Задание 9 \n");
                            Console.Write("Введите сумму  \n");
                            double v = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Выберите валюту \n 1 - USD \n 2 - EUR \n 3 - UAH \n");
                            int n = Convert.ToInt32(Console.ReadLine());
                            if (n == 1)
                            {
                                Console.Write($"{v * 0.91} EUR {v * 23.75} UAN\n");
                            }
                            else if (n == 2)
                            {
                                Console.Write($"{v * 1.11} USD {v * 26.10} UAN\n");
                            }
                            else if (n == 3)
                            {
                                Console.Write($"{v / 23.75:f2} USD {v / 26.10:f2} EUR\n");
                            }
                            else
                                Console.Write("Неправельный ввод\n");
                            break;
                        }
                    case 14:
                        {
                            Random rnd2 = new Random();
                            int summ=0;
                            Console.Write("Задание 14\n");
                            for (int i = 1; i < 6; i++)
                            {
                                int num = rnd2.Next(1, 200);
                                summ = summ + num;
                                Console.WriteLine($"число {num} \n ");
                            }
                            Console.Write($"сумма {summ} среднее арифметическое {summ/5}\n");
                            break;
                        }
                    case 13:
                        {
                            Console.Write("Задание 13\n");
                            Console.Write("Введите 5 чисел  \n");
                            
                            string[] num = Console.ReadLine().Split(' ');
                            int a = int.Parse(num[0]);
                            int b = int.Parse(num[1]);
                            int c = int.Parse(num[2]);
                            int g = int.Parse(num[3]);
                            int h = int.Parse(num[4]);
                            Console.Write($" среднее арифметическое {(a+b+c+g+h)/5}\n");
                            break;
                        }
                    case 15:
                        {
                            Console.Write("Задание 15\n");
                            Console.Write("Введите 64 лапки  \n");
                            int nl = int.Parse(Console.ReadLine());
                            for (int k = 0; k <= nl / 4; k++)
                               Console.WriteLine("кроликов k = {0}\t, гусей g = {1}\t", k, (nl - 4 * k)/2);
                            break;


                        }
                    case 10:
                        {
                            Console.Write("Введите N  \n");
                            int res = int.Parse(Console.ReadLine());

                            for (int a = 1; a <= 20; a++)
                            {
                                for (int b = 1; b <= res; b++)
                                {
                                    if(b==res)
                                    Console.WriteLine("{0}*{1}={2} разряд {3} ", b, a, (a * b), ((int)Math.Log10(a* b) + 1));
                                }
                            }
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Введите N  \n");
                            int res = int.Parse(Console.ReadLine());
                            int m = 0;
                            for (int pow = 1; pow <= res; pow++)
                            {
                                m = (pow * pow);
                                if (m >= res)
                                    break;

                                else
                                        {
                                           Console.WriteLine($"{pow} квадрат  {m} ");
                                        }
                                
                            }
                                break;
                        }
                    case 11:
                        {
                            Random rnd = new Random();
                            Console.Write("Задание 11 \n");
                            Console.Write("Угадайте число \n");
                            int n = 0;
                            int number = rnd.Next(1, 146);
                            do
                            {
                                n = Convert.ToInt32(Console.ReadLine());
                                if (n == number)
                                {
                                    Console.Write(" Вы угадали \n");
                                    continue;
                                }
                                else if (n < number)
                                {
                                    Console.Write("Больше \n");
                                }
                                else
                                    Console.Write("Meньше \n");
                            }
                            while (n != number);
                            break;
                        }
                    case 16:
                        {
                            Random rnd = new Random();
                            Console.Write("Задание 16 \n");
                            Console.Write("Введите пароль \n");
                            string root = "root";
                            string pass = "";
                            do
                            {
                                pass = Convert.ToString(Console.ReadLine());
                                if (pass != root)
                                {
                                    Console.Write(" Неверно \n");
                                    continue;
                                }
                                else
                                    Console.Write("Верно\n");
                            }
                            while (pass != root);
                            break;
                        }

                    default:
                     Console.Write("нажмите 0 \n");

                    break;


                }
                Console.ReadLine();
                Console.Clear();

            }
            while (worknumber != 0);

        }
    }
}
