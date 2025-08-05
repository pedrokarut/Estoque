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

        public Produtos(string name,  double value, int litros, string cod_barras)
        {
            this.name = name;
            this.value = value;
            this.litros = litros;
            this.cod_barras = cod_barras;
        }

    }
}
