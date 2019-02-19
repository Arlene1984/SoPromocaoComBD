using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace So_Promocao_Com__BD.Models
{
    public class Empresa
    {
        public int id { get; set; }
        public int cnpj { get; set; }
        public string bairro { get; set; }
        public string senha { get; set; }
        public string fraseSeguranca { get; set; }
        public string numero { get; set; }
        public string telefone { get; set; }
        public string solicitante { get; set; }
        public string acordoDeContrato { get; set; }
        public string cidade { get; set; }
        public string razaoSocial { get; set; }
        public string cep { get; set; }
        public string email { get; set; }
        public string rua { get; set; }
    }
}