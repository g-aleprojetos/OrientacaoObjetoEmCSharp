using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objetp
            Pessoa obj = new Pessoa();

            obj.nome = "Alexandre";
            obj.idade = 43;

            obj.mensagem();
        }
    }
}
