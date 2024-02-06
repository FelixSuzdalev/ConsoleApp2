using System;
namespace Task_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите n");
            int n, i = 3;
            double sum = 0, proiz = 1;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Для n = {0}",n);
            for (; n >= i; i++)
            {
                double an = i + 1.5;
                an = (an - 1 + an - 2) / 2;
                Console.WriteLine("a{0} = {1}", i, an);
                if (an % 2 == 0) proiz *= an;
                else sum+=an;
            }
            Console.WriteLine("Сумма нечетных членов = {0}\nПроизведение четных членов = {1}", sum, proiz);
        }
    }
}


