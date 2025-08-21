namespace calculadora_cs.Services
{
    public class Methods
    {
        public double Sum(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtration(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divide(double n1, double n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }

            return n1 / n2;
        }
    }
}
