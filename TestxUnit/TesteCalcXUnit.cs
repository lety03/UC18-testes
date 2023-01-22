using Uc18Testes;

using Xunit;

namespace TestxUnit
{
public class TesteCalcXUnit
{
    [Fact]
    public void SomarDoisNumeros()
    {

        double pNum = 1;
        double sNum = 1;
        double rNum = 2;

        var resultado = Calculadora.Somar(pNum, sNum);

        Assert.Equal(rNum, resultado);
    }
    
    [Theory]
    [InlineData(1,1,2)]
    [InlineData(2,3,5)]
    [InlineData(7,3,10)]
    public void SomarDoisNumerosLista(double pNum, double sNum, double rNum){

        var resultado = Calculadora.Somar(pNum, sNum);

        Assert.Equal(rNum, resultado);

    }
}
}