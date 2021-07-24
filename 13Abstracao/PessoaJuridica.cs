using System;

namespace _13Abstracao
{
    class PessoaJuridica : Padrao
    {
            //Método obrigatório
       public override void taxaEmprestimo(double valor)
       {
           System.Console.WriteLine("Taxa de empréstimo para pessoa Jurídica R$ " + (valor * 0.2));
       } 
    }
}