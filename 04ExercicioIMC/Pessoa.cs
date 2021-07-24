using System;
using System.Globalization;

namespace _04ExercicioIMC
{
    public class Pessoa
    {
       public double peso;
       public double altura;

       public double imc()
       {
           return peso / (altura * altura);
       } 

       public string situacaoIMC(double valorIMC){
           if(valorIMC < 18.5) 
                return "abaixo do peso";
            else if(valorIMC < 25)
                return "peso normal";
            else if(valorIMC < 30)
                return "acima do peso";
            else if(valorIMC < 35)
                return "obesidade I";
            else if(valorIMC < 40)
                return "obesidade II";
            else
                return "obesidade III";
       }

       public void mensagem()
       {
           //obter IMC com peso e a altura
           double obterIMC = imc();

            //obter a situação do imc
            string obterSituacaoIMC = situacaoIMC(obterIMC);

            //mensagem
            System.Console.WriteLine("Com o peso: " + peso + " e a altura " + altura + " o valor IMC = " + obterIMC.ToString("F2", CultureInfo.InvariantCulture) + " : " + obterSituacaoIMC + ".");

       }
    }
}