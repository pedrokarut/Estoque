using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("vendas")]
    public class Vendas
    {
        [Key]
        public int id { get; private set; }

        public int id_usuario { get; set; }
        public int id_cliente { get; set; }

        public decimal valor_total { get; set; }

        public string forma_pagamento   { get; set; }

        public string tstamp { get; set; }

        public string obs {  get; set; }

        public Vendas()
        {

        }

    }
}
