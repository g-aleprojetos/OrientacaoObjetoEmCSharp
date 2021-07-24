using System;

namespace _13Abstracao
{
    class PessoaFisica : Padrao
    {
       //Método obrigatório
       public override void taxaEmprestimo(double valor)
       {
           System.Console.WriteLine("Taxa de empréstimo para pessoa Física R$ " + (valor * 0.1));
       } 
    }
}