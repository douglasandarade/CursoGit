﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp2
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return (largura * altura);
        }

        public double Perimetro()
        {
            return 2 * (largura + altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(largura,2) + (Math.Pow(altura,2)));
        }
    }
}
