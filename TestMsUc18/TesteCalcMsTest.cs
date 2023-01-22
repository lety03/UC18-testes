using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uc18Testes;

namespace TestMsUc18
{
[TestClass]
public class TesteCalcMsTest
{
    [TestMethod]

    public void TesteSomarDoisNumeros()
    {

        double pNum = 1;
        double sNum = 1;
        double rNum = 2;

        var resultado = Calculadora.Somar(pNum, sNum);


        Assert.AreEqual(rNum, resultado);
        
    }

    [DataTestMethod]
    [DataRow(1,2,3)]
    [DataRow(2,2,4)]
    [DataRow(2,5,7)]

    public void TesteSomarDoisNumeros(double pNum, double sNum, double rNum){

        var resultado = Calculadora.Somar(pNum, sNum);

        Assert.AreEqual(rNum, resultado);       
    }
}
}