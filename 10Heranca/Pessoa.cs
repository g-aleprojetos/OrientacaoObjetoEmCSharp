using System;

namespace _10Heranca
{
    public class Pessoa
    {
        //Atributo
        protected string nome;
        protected int idade;

        //Método
        protected void mensagemPessoa()
        {
            System.Console.WriteLine($"Mome {nome} ");
            System.Console.WriteLine($"Idade {idade} ");
        }
    }
}