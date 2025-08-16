using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("historico")]
    public class Historicos
    {
        [Key]
        public int id { get; set; }

        public int id_usu { get; set; }

        public string obs { get; set; }        

        public string tstamp { get; set; }



        public Historicos()
        {            
        }

    }
}
