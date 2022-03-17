using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, int idade)
        {

        }
        public Pessoa(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
               Nome = nome;
            }
        }
        public string Nome { get; set; }
        protected int AnoOrigem { get; set; }
    }
    public sealed class PessoaFisica : Pessoa
    {
        public PessoaFisica()
        {
            
        }
        public PessoaFisica(string nome) : base(nome)
        {
        }
        public PessoaFisica(string nome, int idade): base(nome, idade)
        {
        }
        public string Cpf { get; set; }

        public void Teste()
        {
            AnoOrigem = 1980;
        }
    }

    public class Empresa
    {
        public List<PessoaFisica> Funcionarios { get; set; }

        void Teste()
        {
            Funcionarios.First().Cpf = "187174784";
        }
    }
}
