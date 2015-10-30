using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using WebServiceExample.Model;

namespace WebServiceExample
{
    [Serializable]
    public class Pessoa
    {
        [XmlElement("Nome")]
        public string Nome {get; set;}

        [XmlElement("Idade")]
        public int Idade { get; set; }
        
        [XmlArrayItem("Endereco")]
        public List<Endereco> Enderecos { get; set; }

        [XmlArrayItem("Numero")]
        public List<String> Telefones { get ; set; }

        public Pessoa()
        {
            this.Enderecos = new List<Endereco>();
            this.Telefones = new List<String>();
        }
        
        public void addTelefone(string telefone)
        {
            this.Telefones.Add(telefone );
        }

        public void addEndereco(string logradouro, string numero, string bairro, List<String> complementos)
        {
            this.Enderecos.Add(new Endereco() { Logradouro = logradouro, Numero = numero, Bairro = bairro , Complementos = complementos});
        }
    }


}
