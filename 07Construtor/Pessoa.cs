using System;

namespace _07Construtor
{
    public class Pessoa
    {
        

        //Construtor
        public Pessoa()
        {
            System.Console.WriteLine("Construtor executado");
        }

        public Pessoa(string nome)
        {
            System.Console.WriteLine($"Meu nome é {nome}");
        }
    }
}