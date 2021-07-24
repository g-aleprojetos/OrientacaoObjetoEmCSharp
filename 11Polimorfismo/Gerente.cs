using System;

namespace _11Polimorfismo
{
    public class Gerente : Imposto
    {
        //Método
        public override void valeAlimentacao(double salario)
        {
            System.Console.WriteLine("Desconto gerente do vale alimentação R$ " + (salario * 0.15));
        }
    }
}