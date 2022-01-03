using System;

namespace strategy.ConcreteStrategy
{
    public class Dividir : Calculadora
    {
         public override double Operacao(double v1, double v2)
        {
            if(v2 == 0)
            throw new InvalidOperationException();
            
            return v1/v2;
        }
    }
}