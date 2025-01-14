﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Conversions *****\n");

            // Создать экземпляр Rectangle.
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();
            Console.WriteLine();

            // Преобразовать r в Square на основе высоты Rectangle.
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();
            Console.WriteLine();

            // Преобразовать Rectangle в Square для вызова метода.
            Rectangle rect = new Rectangle(10, 5);
            DrawSquare((Square)rect);

            // Преобразование int в Square.
            Square sq2 = (Square)90;
            Console.WriteLine("sq2 = {0}", sq2);

            // Преобразование Square В int.
            int side = (int)sq2;
            Console.WriteLine("Side length of sq2 = {0}", side);

            // Неявное преобразование работает!
            Square s3 = new Square { Lenght = 7 };
            Rectangle rect2 = s3;
            Console.WriteLine("rect2 = {0}", rect2);

            // Синтаксис явного приведения также работает!
            Square s4 = new Square { Lenght = 3 };
            Rectangle rect3 = (Rectangle)s4;
            Console.WriteLine("rect3 = {0}", rect3);
            Console.ReadLine();
        }
        /// <summary>
        /// Этот метод требует параметр типа Square.
        /// </summary>
        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}
