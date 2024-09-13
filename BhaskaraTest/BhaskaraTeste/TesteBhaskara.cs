namespace BhaskaraTeste
{
    public class TesteBhaskara
    {
        [Fact]
        public void Test1()
        {
            double a = 4;
            double b = 2;
            double c = -6;

            var raizes = BhaskaraTest.Calculadora.CalcRaiz(a, b, c);

            Assert.Equal(raizes, BhaskaraTest.Calculadora.CalcRaiz(a,b,c));
        }
    }
}