using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.models
{
    public class CalculadoraBasica
    {
        public double Somar(double x, double y)
        {
            return x + y;
        }
        public double Subtrair(double x, double y)
        {
            return x - y;
        }
        public double Multiplicar(double x, double y)
        {
            return x * y;
        }
        public double Dividir(double x, double y)
        {
            return x / y;
        }
        public double Potencializar(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public double Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            return Math.Round(seno, 4);
        }
        public double Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            return Math.Round(coseno, 4);
        }
        public double Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            return Math.Round(tangente, 4);
        }

        public double RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            return Math.Round(raiz, 4);
        }

    }
}