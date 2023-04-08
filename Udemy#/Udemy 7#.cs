using System;

namespace Test
{
    class Test
    {
        static void Main(String[] args)
        {
            int x  = int.Parse(Console.ReadLine());

            string day;

            switch (x)
            {
                case 1: day = "Sunday";
                   break;
                case 2: day = "Monday";
                    break;
                case 3: day = "Thursday";
                    break;
                default: day = "Invalid Data";
                    break;
            }
            Console.WriteLine("Dia: " + day);
        }
    }
}