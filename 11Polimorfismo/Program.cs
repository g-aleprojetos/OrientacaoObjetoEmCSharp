using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar Estagiário
            Imposto objetE = new Estagiario();
            objetE.valeAlimentacao(1000);
            objetE.valeTransporte(1000);
            System.Console.WriteLine("------------------------");

            //Instanciar Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
            System.Console.WriteLine("------------------------");

            //Instanciar Atendente
            Imposto objetA = new Atendente();
            objetA.valeAlimentacao(2000);
            objetA.valeTransporte(2000);
        }
    }
}
