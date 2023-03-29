using System;

namespace TASK
{
    class Basics
    {

    static void Main()
        
        {
            //split entrada de dados

            //string s = Console.ReadLine();
            string[] Sv = Console.ReadLine().Split(' ');
            string a = Sv[0];
            int b = int.Parse(Sv[1]);
            char c = char.Parse(Sv[2]);

            // double d = double.Parse(Sv[3], CultureInfo.InvariantCulture);


            //tipos inplicitos

            /*
            int n1 = 3 + 4 * 2;     //11
            int n2 = (3 + 4) * 2;   //14
            int n3 = 17 % 3;        //2
            double n4 = (double) 10.0 / 8; //1,25

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = b * b - 4.0 * a * c;
            double delta_math = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            */

            /*
            int a = 5;
            int b = 2;

            double resultado = (double) a / b;

            double c;
            int d;

            c = 5.1;

            b = (int) a;

            
            float x = 4.5f;

            double y = x;
            

            int l = 10;

            l += 10;

            string s = "abc";

            s += "defgh";

            l++;

            int t = 10;
            int f = ++t;
            int r = t++;
            */
        }

    }
} 