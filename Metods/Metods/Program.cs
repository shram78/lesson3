using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;// Шрам А.В., урок 3, упражение 1.а
/*1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;*/

namespace Metods
{
    class Program
    {
        struct Complex
        {
            public double re; // действительная часть
            public double im; // мнимая часть
            public Complex Plusss(Complex x)
            {
                Complex summ;
                summ.re = re + x.re;
                summ.im = im + x.im;
                return summ;
            }
            public Complex Minusss(Complex x)
            {
                Complex minus;
                minus.re = re - x.re;
                minus.im = im - x.im;
                return minus;
            }
            public override string ToString()
            {
                return $"{re} + {im}i";
            }
        }
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 20;
            complex1.im = 55;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 5;

            Console.WriteLine($"Работа с комплексными числами:\t\t {complex1} и {complex2}");
            Console.WriteLine($"Результат сложения комплексных чисел:\t {complex1.Plusss(complex2)}");
            Console.WriteLine($"Результат вычитания комплексных чисел:\t {complex1.Minusss(complex2)}");



            Console.ReadLine();


        }
    }
}
