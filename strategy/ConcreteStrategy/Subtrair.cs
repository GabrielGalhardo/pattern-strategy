using System;

namespace strategy.ConcreteStrategy
{
    public class Subtrair : Calculadora
    {
        public override double Operacao(double v1, double v2)
        {
            if(v2>v1)
            throw new InvalidOperationException();
            
            return v1 - v2;
        }
    }
}