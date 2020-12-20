using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;      // Шрам А.В., урок 3, упражение 2

/*2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;*/

namespace EnterNum
{
    class Program
    {
        static void ErrorEnter() // метод для вывода сообщения о неправильном вводе
        {
            Console.WriteLine("Ошибка, введите число, а не символ\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать сумму всех нечетных положительных чисел\n");
            int summ = 0; // для подсчета суммы всех введенных чисел
            int ryad = 0; // для хранения значения, введенного пользователем
            do
            {
                bool check = false;  //бесконечный цикл, пока пользователь не введет целое число либо ноль
                while (!check)
                {
                    Console.Write("Введите число, для окончания набора введите ноль: \n");
                    check = int.TryParse(Console.ReadLine(), out ryad);
                    if (!check)
                        ErrorEnter();
                }
                    
                if (ryad > 0 && ryad % 2 == 1) // проверка на нечетность и положительность введенног числа, суммирование
                {
                    summ = summ + ryad;
                 }
            } while (ryad != 0);
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна: {summ}");
            Console.ReadLine();
        }
    }
}