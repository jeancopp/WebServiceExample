using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceExample
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceExample : System.Web.Services.WebService
    {

        [WebMethod]
        public Pessoa Recurso()
        {
            var complementos1 = new String[] { "Complemento1", "Complemnto2"}.ToList<String>() ;
            var complementos2 = new String[] { "Complemento3", "Complemnto4" }.ToList<String>();

            var retorno = new BuilderEstruturaComplexa()
                                .addNome("Nome")
                                .addIdade(25)
                                .addTelefone("Telefone 1")
                                .addTelefone("Telefone 1")
                                .addEndereco("Endereco 1", "Número 1", "Bairro 1", complementos1)
                                .addEndereco("Endereco 2", "Número 2", "Bairro 2", complementos2)
                                .build();
            return retorno;
        }
    }
}
