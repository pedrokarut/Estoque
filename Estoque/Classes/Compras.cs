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

        public string name { get; private set; }

        public double value { get; private set; }

        public Compras(string name,  double value)
        {
            this.name = name;
            this.value = value;
        }

    }
}
