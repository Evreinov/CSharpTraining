﻿using System;

namespace CustomInterface
{
    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }
        // Реализация IPointy.
        public byte Points
        {
            get { return 3; }
        }
    }
}
