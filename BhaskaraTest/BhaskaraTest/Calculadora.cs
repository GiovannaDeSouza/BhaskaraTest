namespace BhaskaraTest
{
    public class Calculadora
    {
        public static double[] CalcRaiz(double a, double b, double c)
        {
            double Delta = (b * b) - 4 * (a * c);

            if (Delta < 0)
            {
                throw new ArgumentOutOfRangeException("Não é possivel concluir a bhaskara, Delta negativo");
            }

            double raizUm = ((b * -1) + Math.Sqrt(Delta)) / 2 * a;
            double raizDois = ((b * -1) - Math.Sqrt(Delta)) / 2 * a;

            return new double[] { raizUm, raizDois };

        }

    }
}
