using System;

namespace _08GetSet
{
    public class Pessoa
    {
        //Atributo 
        private string nome;

        //Get e Set

        public string Nome 
        { 
            get{return nome;}
            set{nome=value;}
        }
    }
}