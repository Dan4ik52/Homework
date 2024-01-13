using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Обработать тестовое задание по информатике. На экран вывести вопрос и три варианта ответа, ввести с экрана вариант ответа.
            //Программа должна оценить ответ и в случае неправильного ответа написать правильный.
            /*
            string t = "Что делает try-catch?";
            string a = "Работает с базой данных";
            string b = "Работает с исключениями";
            string c = "Работает с классами";

            Console.WriteLine(t);
            Console.WriteLine($"1.{a}\t2.{b}\t3.{c}");
            Console.Write("Введите ваш вариант ответа: ");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("Верно!");
            }
            else
            {
                Console.WriteLine($"Неверно!\nПравильный ответ: {b}");
            }
            */


            //2. Написать программу вычисления стоимости переговоров, если по субботам и воскресеньям предоставляется 20% скидка.
            //Ввести продолжительность разговора и день недели (цифра от 1 до 7).
            /*
            double price = 0.3; 
            double discount = 0.8;
            Console.Write("Введите продолжительность разговора: ");
            double duration = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите день недели (цифра от 1 до 7): ");
            int day = int.Parse(Console.ReadLine());

            if (day == 6 || day == 7)
            {
                Console.WriteLine($"Стоимость перегворов = {duration * price * discount}");
            }
              else
            {
                Console.WriteLine($"Стоимость перегворов = {duration * price}");
            }  
            */

            //3. Написать программу для определения времени суток по данному текущему времени и вывести сообщение
            //(утро – с 6 до 12, день – с 12 до 18, вечер – с 18 до 24, ночь – с 0 до 6).
            /*
            Console.Write("Введите время: "); 
            int time = int.Parse(Console.ReadLine());

            if (time >= 6 && time < 12)
            {
                Console.Write("Сейчас утро!");
            }
            else if (time >= 12 && time < 18)
            {
                Console.Write("Сейчас день!");
            }
            else if (time >= 18 && time < 24)
            {
                Console.Write("Сейчас вечер!");
            } 
            else if (time >= 0 && time < 6)
            {
                Console.Write("Сейчас ночь!");
            }
            */


            //4. Рейтинг бакалавра заочного отделения при поступлении в магистратуру определяется средним баллом по диплому,
            //умноженным на коэффициент стажа работы по специальности, который равен: нет стажа – 1, меньше 2 лет – 13,
            //от 2 до 5 лет – 16. Составить программу расчета рейтинга при заданном среднем балле диплома (от 3 до 5) и вывести сообщение о приеме в магистратуру при проходном балле 45.
            /*
            Console.Write("Введите свой средний балл: ");
            double point = double.Parse(Console.ReadLine()); 
            Console.Write("Введите свой стаж работы: ");
            int experience = int.Parse(Console.ReadLine());

            int coefficient = 1;
            if ( experience < 2 )
            {
                coefficient = 13;
            }
            else if ( experience <= 5 )
            {
                coefficient = 16;
            }

            double rating = point * coefficient;

            if (rating > 45)
            {
                Console.Write($"Вы приняты!\nВаш рейтинг: {point * coefficient}");
            }
            else
            {
                Console.Write($"К сожалению, вы не приняты\nВаш рейтинг: {point * coefficient}");
            }
            */


            //5. Написать программу , которая по дате рождения (день d месяц n) определяет знак Зодиака:
            //с 22 марта по 21 апреля - Овен (4); с 22 апреля по 21 мая - Телец (5); с 22 мая по 21 июня - Близнецы (6); с 22 июня по 21 июля - Рак (7); с 22 июля по 21 августа - Лев (8);
            //с 22 августа по 21 сентября - Дева (9); с 22 сентября по 21 октября - Весы (10); с 22 октября по 21 ноября - Скорпион (11); с 22 ноября по 21 декабря - Стрелец (12);
            //с 22 декабря по 21 января - Козерог (1); 22 января по 21 февраля - Водолей (2); с 22 февраля по 21 марта - Рыбы (3).

            /*
            Console.Write("Введите день рождения (от 1 до 31): ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц рождения (от 1 до 12): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ваш знак зодиака: ");
            if (d >= 22 && n == 1 || d <= 21 && n == 2)
            {
                Console.WriteLine("Водолей");
            }
            else if (d >= 22 && n == 2 || d <= 21 && n == 3)
            {
                Console.WriteLine("Рыбы");
            }
            else if (d >= 22 && n == 3 || d <= 21 && n == 4)
            {
                Console.WriteLine("Овен");
            }
            else if (d >= 22 && n == 4 || d <= 21 && n == 5)
            {
                Console.WriteLine("Телец");
            }
            else if (d >= 22 && n == 5 || d <= 21 && n == 6)
            {
                Console.WriteLine("Близнецы");
            }
            else if (d >= 22 && n == 6 || d <= 21 && n == 7)
            {
                Console.WriteLine("Рак");
            }
            else if (d >= 22 && n == 7 || d <= 21 && n == 8)
            {
                Console.WriteLine("Лев");
            }
            else if (d >= 22 && n == 8 || d <= 21 && n == 9)
            {
                Console.WriteLine("Дева");
            }
            else if (d >= 22 && n == 9 || d <= 21 && n == 10)
            {
                Console.WriteLine("Весы");
            }
            else if (d >= 22 && n == 10 || d <= 21 && n == 11)
            {
                Console.WriteLine("Скорпион");
            }
            else if (d >= 22 && n == 11 || d <= 21 && n == 12)
            {
                Console.WriteLine("Стрелец");
            }
            else
            {
                Console.WriteLine("Козерог");
            }
            */



            //6. Написать программу, которая при вводе числа в диапазоне от 1 до 99 добавляет к нему слово "копейка" в правильной форме. Например, 1 копейка, 5 копеек, 42 копейки.
            /*
            Console.Write("Введите число (от 1 до 99): ");
            int coin = int.Parse(Console.ReadLine());

            if (coin % 10 >= 5 || coin >= 5 && coin <= 20 || coin % 10 <= 0 )      
            {
                Console.WriteLine($"{coin} копеек");
            }
            else if (coin % 10 == 1)
            {
                Console.WriteLine($"{coin} копейка");
            }
            else if (coin % 10 >= 2 || coin % 10 <= 4)
                Console.WriteLine($"{coin} копейки");
            */


            //7. Написать программу, которая после введенного с клавиатуры числа в диапазоне от 1 до 99 дописывает слово «рубль» в правильном падеже.
            /*
            Console.Write("Введите число (от 1 до 99): ");
            int coin = int.Parse(Console.ReadLine());

            if (coin % 10 >= 5 || coin >= 5 && coin <= 20 || coin % 10 <= 0)
            {
                Console.WriteLine($"{coin} рублей");
            }
            else if (coin % 10 == 1)
            {
                Console.WriteLine($"{coin} рубль");
            }
            else if (coin % 10 >= 2 || coin % 10 <= 4)
                Console.WriteLine($"{coin} рубля");
            */













            Console.ReadKey();
        }
    }
}
