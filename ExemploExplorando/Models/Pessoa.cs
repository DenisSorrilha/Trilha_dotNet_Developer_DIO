using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        //Construtor vazio
        public Pessoa() {

        }
        //Construtor Pessoa
        public Pessoa(string nome, string sobrenome) {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Criando um desconstrutor
        public void Deconstruct (out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome;
        private int _idade;

        //Propriedade Nome
        public string Nome { 
            get => _nome.ToUpper();

            set {
                if (value == "") {
                    throw new ArgumentException("O nome não pode ser vazio!");                    
                }

                _nome = value;
            } 
        }

        //Propriedade Sobrenome
        public string Sobrenome { get; set; }

        //Variável NomeCompleto converte o sobrenome para maiúsculo.
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        //Propriedade Idade
        public int Idade { 
            get => _idade;
            
            set  {
                if (value < 0) {
                    throw new ArgumentException("A idade não pode ser menor que 0!");
                }

                _idade = value;
            }
        }

        // Metódo Apresentar
        public void Apresentar() {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
            
        }
    }
}