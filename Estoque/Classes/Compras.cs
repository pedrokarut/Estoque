using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("compras")]
    public class Compras
    {
        [Key]
        public int id { get; private set; }

        public int id_prod { get;  set; }

        public int id_fornecedor { get; set; }

        public int qtd { get;  set; }

        public string tstamp { get; set; }

        public Compras()
        {
        }

    }
}
