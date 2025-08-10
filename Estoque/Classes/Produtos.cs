using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("produtos")]
    public class Produtos
    {
        [Key]
        public int id { get; private set; }

        public string name { get; set; }

        public double value { get; set; }

        public int litros { get; set; }

        public string cod_barras { get; set; }

        public double custo { get; set; }

        public double margem { get; set; }

        public int id_fornecedor { get; set; }

        public int qtd {  get; set; }

        public Produtos()
        { }

    }
}
