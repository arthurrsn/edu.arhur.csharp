using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu.arthur.csharp.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa(string nome, int idade)
        {
            this._nome = nome;
            this._idade = idade;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }



        /* Encapsulamento Abaixo */ 
        public string Nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }
        public int Idade
        {
            get { return this._idade; }
            set { this._idade = value; }
        }

    }
}