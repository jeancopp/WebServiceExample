using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServiceExample.ModelBuilder;

namespace WebServiceExample
{
    class BuilderEstruturaComplexa: Builder<Pessoa>
    {
        private Pessoa estruturaComplexa;

        public BuilderEstruturaComplexa()
        {
            this.estruturaComplexa = new Pessoa();
        }

        public BuilderEstruturaComplexa addNome(string nome)
        {
            this.estruturaComplexa.Nome = nome;
            return this;
        }

        public BuilderEstruturaComplexa addIdade(int idade)
        {
            this.estruturaComplexa.Idade = idade;
            return this;
        }
        public BuilderEstruturaComplexa addTelefone(string telefone)
        {
            this.estruturaComplexa.addTelefone(telefone);
            return this;
        }

        public BuilderEstruturaComplexa addEndereco(string logradouro, string numero, string bairro, List<String> complementos)
        {
            this.estruturaComplexa.addEndereco(logradouro, numero, bairro, complementos);
            return this;
        }

        public Pessoa build()
        {
            return this.estruturaComplexa;
        }
    }
}
