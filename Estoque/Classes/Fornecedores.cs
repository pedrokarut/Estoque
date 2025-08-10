using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("fornecedores")]
    public class Fornecedores
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public string cnpj { get; set; }

        public string incricao_estadual { get; set; }

        public string telefone { get; set; }

        public string tstamp { get; set; }



        public Fornecedores()
        {
            
        }

    }
}
