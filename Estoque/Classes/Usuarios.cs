using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Key]
        public int id { get; private set; }

        public string name { get; set; }

        public string usr { get; set; }

        public string senha { get; set; }

        public DateTime tstamp { get; set; } 

        public Usuarios(string name,  string usr, string senha, DateTime tstamp)
        {
            this.name = name;
            this.usr = usr;
            this.senha = senha;
            this.tstamp = tstamp;
            
        }

    }
}
