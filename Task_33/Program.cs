using System;

namespace Task_33
{
    class Program
    {
        static void Main()
        {

            double shadow = 1.5; 
           
            Console.WriteLine("В 7:00 тень от вертикально стоящей палки 1 м была 1,5 м\nВведите первый и второй промежуток времени, чтобы узнать длину тени именно в этом периоде (c 8 до 19):");
            uint time1 = Convert.ToUInt32(Console.ReadLine());
            uint time2 = Convert.ToUInt32(Console.ReadLine());
                    
            if (time1 <= 19 && time1 >= 8 && time2 <= 19 && time1 <= time2)
            {
                Console.WriteLine("Таблица длин теней метровой палки\n\nВремя:\t\tДлина тени:");
                for (; time1 <= time2; time1++)
                {
                    Console.Write($"{time1}:00");
                    if (time1 <= 15.00)
                    {
                        shadow -= 0.1875;
                        Console.WriteLine("\t\t{0}", shadow);
                    }
                    else
                    {
                        shadow += 0.1875;
                        Console.WriteLine("\t\t{0}", shadow);
                    }
                }
            }
            else Console.WriteLine("Неправильный ввод");
            Console.ReadLine();

        }
    }
}
