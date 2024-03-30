using System;
using System.IO;

namespace Lab2
{
    class Par 
    {
        private double a, b, c;
        public double GetV()
        {
            return a * b * c;
        }

        public double GetS()
        {
            return 2 * (a * b + b * c + a * c);
        }

        public void Info()
        {
            String str = "[-----Информация о параллелепипеде-----]";
            Console.WriteLine(str);
            Console.WriteLine(string.Format(
                "A = {0:0.000}, B = {1:0.000}, C = {2:0.000}", a, b, c));
            Console.WriteLine(string.Format("V = {0:0.000}", GetV()));
            Console.WriteLine(string.Format("S = {0:0.000}", GetS()));
        }

        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Graph 
    {
        private double a, b;

        public double Integral()
        {
            double intA = (1.0 / 2) * a * a;
            double intB = (1.0 / 2) * b * b;
            return intB - intA;
        }

        public double Length()
        {
            double dX = b - a;
            double dY = b - a;
            return Math.Sqrt(dX * dX + dY * dY);
        }

        public void Info()
        {
            Console.WriteLine("[--- Информация о графике y = x ---]");
            Console.WriteLine(string.Format("Значения A = {0:0.00} и B = {1:0.00}", a, b));
            Console.WriteLine(string.Format("Длина отрезка функции: {0:0.00}",Length()));
            Console.WriteLine(string.Format("Интеграл функции для A = {0:0.00} и B = {1:0.00}: {2:0.00}", a, b, Integral()));
        }

        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetIn(new_in);
            Console.SetOut(new_out);
#endif
            Par p = new Par();
            p.Load();
            p.Info();
            Console.WriteLine("\n");
            Graph g = new Graph();
            g.Load();
            g.Info();
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}