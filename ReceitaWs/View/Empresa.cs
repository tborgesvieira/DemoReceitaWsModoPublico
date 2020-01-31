using System;
using System.Collections.Generic;

namespace ReceitaWs.View
{
    public class Empresa
    {
        public List<AtividadePrincipal> Atividade_Principal { get; set; }
        public string Data_Situacao { get; set; }
        public string Complemento { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public List<object> Qsa { get; set; }
        public string Situacao { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Municipio { get; set; }
        public string Porte { get; set; }
        public string Abertura { get; set; }
        public string Natureza_Juridica { get; set; }
        public string Fantasia { get; set; }
        public string CNPJ { get; set; }
        public DateTime Ultima_Atualizacao { get; set; }
        public string Status { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public string Efr { get; set; }
        public string Motivo_Situacao { get; set; }
        public string Situacao_Especial { get; set; }
        public string Data_Situacao_Especial { get; set; }
        public List<AtividadesSecundaria> Atividades_Secundarias { get; set; }
        public string Capital_Social { get; set; }
    }
}
