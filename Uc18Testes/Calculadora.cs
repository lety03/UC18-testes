﻿namespace Uc18Testes;

public static class Calculadora
{
    public static double Somar(double pNum, double sNum)
    {
        return (pNum + sNum);
    }

    public static string CalcularImc(double kg, double altura)
    {
        double resultado = kg/ (altura * altura);

        if(resultado < 18.5)
        {
            return "Abaixo do peso";
        }
        if(resultado < 24.9){
            return "Peso normal";
        }
        if (resultado < 29.9)
        {
            return "Sobre peso";
        }
        if (resultado < 34.9)
        {
            return "Obesidade grau 1";
        }
        if (resultado < 34.9)
        {
            return "Obesidade grau 2";
        }
        else{
            return "Obesidade grau 3";
        }
    }
}

