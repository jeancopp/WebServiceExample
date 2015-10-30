using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebServiceExample.Model
{
    [Serializable]
    public class Endereco
    {
        [XmlElement("Logradouro")]
        public string Logradouro { get; set; }

        [XmlElement("Numero")]
        public string Numero { get; set; }

        [XmlElement("Bairro")]
        public string Bairro { get; set; }

        [XmlArrayItem("Complemento")]
        public List<String> Complementos { get; set; }
    }
}