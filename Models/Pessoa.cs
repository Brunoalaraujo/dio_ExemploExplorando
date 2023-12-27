using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() // Classes podem ter mais de um construtor. Esse é para podermos digitar o valor do nome/sobrenome após a construção da classe
        {

        }
        public Pessoa(string nome, string sobrenome) // Construtor da classe Pessoa. Sempre tem o mesmo nome da classe.
        {
            Nome = nome; // Propiedade Classe = propiedade construtor
            Sobrenome = sobrenome;
        }
        private string _nome; // Validação de propriedade, novo armazenamento
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper(); // Body Expressios, usar para simpliicar o código.


            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio"); //Tratamento de erro
                }

                _nome = value;
            }

        }
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}