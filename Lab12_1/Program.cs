using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 12");
            int r, x, y;
            double l, s;
            bool enters;
            Console.WriteLine("Задайте радиус: ");
            Cirlce.radius(out r);
            Console.WriteLine("Введите координаты точки");
            Input(out x);
            Input(out y);
            Cirlce.Circumference(r, out l);
            Console.WriteLine("Длина окружности равна: {0}", l);
            Cirlce.Area(r, out s);
            Console.WriteLine("Площадь круга равна: {0}", s);
            Cirlce.Enters(x, y, r, out enters);
            if (enters == true) Console.WriteLine("Координаты точки входят в окружность");
            else Console.WriteLine("Координаты точки не входят в окружность");
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadLine();
        }
        static void Input(out int num)
        {
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка ввода данных. Введите число заново");
                Input(out num);
            }
        }
    }
    public static class Cirlce
    {
        public static void radius(out int r)
        {
            try
            {
                r = Convert.ToInt32(Console.ReadLine());
                if (r <= 0) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных. Введите число заново");
                radius(out r);
            }
        }
        public static void Circumference(int r, out double l)
        {
            l = 2 * Math.PI * r;
        }
        public static void Area(int r, out double s)
        {
            s = Math.PI * r * r;
        }
        public static void Enters(int x, int y, int r, out bool affilation)
        {
            affilation = (Math.Sqrt(x * x + y * y) <= r) ? true : false;
        }
    }
}
