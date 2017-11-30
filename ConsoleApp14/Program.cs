using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
          // Program1();
          // Program2();
           // Program3();
            //Program4();
            Program5();

        }

        private static void Program5()
        {
            int  number, thousand, ten, one; 

            Console.WriteLine("Дано трехзначное число");
            number = int.Parse(Console.ReadLine());
            int hundred = 100, ten1 = 10;
            thousand = number / hundred;
            ten = (number / ten1) % ten1;
            one = number % ten1;
            Console.WriteLine("ответ = {0}{1}{2}",one,ten,thousand);
            Console.ReadLine();
        }

        private static void Program4()
        {
            //4.Даны целые положительные числа A и B(A<B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке;
            //при этом каждое число должно выводиться количество раз, равное его значению. 
            Console.WriteLine("Введите цифры от и до");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
           
            for (int i=a;i<=b;i++)
            {
                Console.Write("\n");
                for (int j=1;j<=i;j++)
                { 
                Console.Write("{0}   ",i);
            }}
            Console.ReadLine();
        }

        private static void Program3()
        {
            //3.Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 
            // 32.Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
            int element, count = 0;
            char i;
            do
            {
                Console.WriteLine("Введите символ");
                Console.WriteLine("если хотите выйти нажмите на точку '.'");
                do
                {
                    element = Console.Read();
                    i = (char)element;
                } while (i == '\n' | i == '\r');

                if (element >= 65 && element <= 90)
                {
                    element += 32;
                    i = (char)element;
                    Console.WriteLine(i);
                    count++;

                }
                else if (element >= 97 && element <= 122)
                {
                    element -= 32;
                    i = (char)element;
                    Console.WriteLine(i);
                    count++;
                }
                else if (element == 46)
                {
                    break;
                }
                else
                {
                    i = (char)element;
                    Console.WriteLine(i);
                }


            } while (element != 46);
            Console.WriteLine("Всего введено " + count + " символов");
        }

        private static void Program2()
        {
            //2.Ввести с клавиатуры номер трамвайного билета(6 - значное число) и про-верить 
            //  является ли данный билет счастливым(если на билете напечатано шестизначное число,
            //  и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
            int[] nomer = new int[6];
            nomer[0] = int.Parse(Console.ReadLine());
            nomer[1] = int.Parse(Console.ReadLine());
            nomer[2] = int.Parse(Console.ReadLine());
            nomer[3] = int.Parse(Console.ReadLine());
            nomer[4] = int.Parse(Console.ReadLine());
            nomer[5] = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int[] nomer1 = { nomer[0], nomer[1], nomer[2] };
            foreach (int i in nomer1)
                sum1 += i;
            Console.WriteLine("Сумма первых 3 цифр = {0}", sum1);

            int sum2 = 0;
            int[] nomer2 = { nomer[3], nomer[4], nomer[5] };
            foreach (int j in nomer2)
                sum2 += j;
            Console.WriteLine("Сумма вторых 3 цифр = {0}", sum2);

            if (sum1 == sum2)
                Console.WriteLine("Билет счастливый!");
            else
                Console.WriteLine("Билет не счастливый.");

            Console.ReadKey();

        }

        private static void Program1()
        {
            //1.Написать программу, которая считывает символы с клавиатуры,
            //пока не будет введена точка.Программа должна сосчитать количество введенных пользователем пробелов.
            Console.WriteLine("введите строку");
            string poem= Console.ReadLine();
            string[] words = poem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            do
            {
                int count = 0;
                if (poem == ".")
                {
                    break;
                }
                else
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        count++;

                    }
                }
                Console.WriteLine("количество введенных пользователем пробелов.{0}", count);
                Console.ReadLine();
                Console.ReadKey();
            } while (poem != ".");
            }
        }

    }


