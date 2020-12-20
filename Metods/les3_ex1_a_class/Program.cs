using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // Шрам А.В., урок 3, упражение 1.б
/*б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;*/
namespace les3_ex1_a_class
{

    class Program
    {

        class Complex
        {
            private double re; // действительная часть
            private double im; // мнимая часть

            public double Re
            {
                get { return re; }
                set { re = value; }
            }

            public double Im
            {
                get { return im; }
                set { im = value; }
            }
            public Complex Plusss(Complex x)
            {
                Complex summ = new Complex();
                summ.re = re + x.re;
                summ.im = im + x.im;
                return summ;
            }
            public Complex Minusss(Complex x)
            {
                Complex minus = new Complex();
                minus.re = re - x.re;
                minus.im = im - x.im;
                return minus;
            }
            public Complex Multipl(Complex x)
            {
                Complex mult = new Complex();
                mult.re = re * x.re;
                mult.im = im * x.im;
                return mult;
            }
            public override string ToString()
            {
                return $"{re} + {im}i";
            }
        }

        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1.Re = 20;
            complex1.Im = 55;

            Complex complex2 = new Complex();
            complex2.Re = 2;
            complex2.Im = 5;

            Console.WriteLine($"Работа с комплексными числами:\t\t {complex1} и {complex2}");
            Console.WriteLine($"Результат сложения комплексных чисел:\t {complex1.Plusss(complex2)}");
            Console.WriteLine($"Результат вычитания комплексных чисел:\t {complex1.Minusss(complex2)}");
            Console.WriteLine($"Результат умножения комплексных чисел:\t {complex1.Multipl(complex2)}");



            Console.ReadLine();


        }
    }
}
