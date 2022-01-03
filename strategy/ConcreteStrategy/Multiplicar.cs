namespace strategy.ConcreteStrategy
{
    public class Multiplicar : Calculadora
    {
         public override double Operacao(double v1, double v2)
        {
            return v1 * v2;
        }
    }
}