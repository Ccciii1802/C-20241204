using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241204
{
    internal class Program
    {
        //1112410047
        public static double CountPi(int n)
        {
            if (n < 4 || n > 20) // 增加範圍到 20
            {
                return -1;
            }

            double pi = 0.0;

            for (int i = 0; i < n; i++)
            {
                double term = 1.0 / (2.0 * i + 1);
                pi += (i % 2 == 0 ? term : -term);
            }

            return pi * 4.0;
        }

        public static double CalculateCircumference(double radius, double pi)
        {
            return 2 * pi * radius;
        }

        public static double CalculateArea(double radius, double pi)
        {
            return pi * radius * radius;
        }

        static void Main()
        {
            Console.WriteLine("請選擇功能：");
            Console.WriteLine("1. 計算圓周率");
            Console.WriteLine("2. 計算圓周長");
            Console.WriteLine("3. 計算圓面積");
            Console.Write("請輸入選項 (1-3): ");

            if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 3)
            {
                Console.WriteLine("無效的選項！");
                return;
            }

            switch (option)
            {
                case 1:
                    Console.Write("請輸入計算 pi 的項數 (4 到 20): ");
                    if (int.TryParse(Console.ReadLine(), out int n))
                    {
                        double piApprox = CountPi(n);
                        if (piApprox == -1)
                        {
                            Console.WriteLine("輸入項數超出範圍！請輸入 4 到 20 之間的值。");
                        }
                        else
                        {
                            Console.WriteLine($"使用 {n} 項近似的 Pi 值為: {piApprox:F15}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("無效的輸入，請輸入數字。");
                    }
                    break;

                case 2:
                    Console.Write("請輸入圓的半徑: ");
                    if (double.TryParse(Console.ReadLine(), out double radiusCircumference))
                    {
                        double pi = CountPi(15);
                        Console.WriteLine($"圓的周長為: {CalculateCircumference(radiusCircumference, pi):F15}");
                    }
                    else
                    {
                        Console.WriteLine("無效的輸入，請輸入數字。");
                    }
                    break;

                case 3:
                    Console.Write("請輸入圓的半徑: ");
                    if (double.TryParse(Console.ReadLine(), out double radiusArea))
                    {
                        double pi = CountPi(15);
                        Console.WriteLine($"圓的面積為: {CalculateArea(radiusArea, pi):F15}");
                    }
                    else
                    {
                        Console.WriteLine("無效的輸入，請輸入數字。");
                    }
                    break;
            }
        }
    }
}
