using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("clientes")]
    public class Clientes
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public string cnpj { get; set; }

        public string incricao_estadual { get; set; }

        public string telefone { get; set; }

        public string tstamp { get; set; }



        public Clientes(string nome,  string endereco, string cnpj, string incricao_estadual, string telefone, string tstamp)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cnpj = cnpj;
            this.incricao_estadual = incricao_estadual;
            this.telefone = telefone;
            this.tstamp = tstamp;
        }

    }
}
