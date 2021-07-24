using System;

namespace _11Polimorfismo
{
    public class Atendente : Imposto
    {
        //Método
        public override void valeAlimentacao(double salario)
        {
            System.Console.WriteLine("Desconto atendente do vale alimentação R$ " + (salario * 0.12));
        }
    }
}