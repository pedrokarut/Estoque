using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("clientes")]
    public class Clientes
    {
        [Key]
        public int id { get; private set; }

        public string name { get; private set; }

        public double value { get; private set; }

        public Clientes(string name,  double value)
        {
            this.name = name;
            this.value = value;
        }

    }
}
