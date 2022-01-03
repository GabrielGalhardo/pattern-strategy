namespace strategy.ConcreteStrategy
{
    public class Somar : Calculadora
    {
        public override double Operacao(double v1, double v2)
        {
            return v1+ v2;
        }
    }
}