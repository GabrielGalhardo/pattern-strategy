using System;

namespace strategy
{
    public class Calcular
    {
        public Calculadora calcular { get; set; }
        public void CalcularOperacao(double v1, double v2)
        {
            Console.WriteLine(calcular.Operacao(v1, v2));
        }  
    }
}