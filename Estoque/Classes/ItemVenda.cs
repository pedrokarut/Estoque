using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Estoque.Classes
{
    [Table("itens_vendas")]
    public class ItemVenda
    {
        [Key]
        public int id { get; private set; }

        public int id_venda { get; set; }
        public int id_usuario { get; set; }

        public int id_cliente { get; set; }

        public int id_produto   { get; set; }

        public decimal valor { get; set; }

        public int qtd {  get; set; }

        public string tstamp { get; set; }

        public ItemVenda(int idven,  int idusu, int idcli , int idpro, decimal v, int qtd, string ts)
        {
            this.id_venda = idven;
            this.id_usuario = idusu;
            this.id_cliente = idcli;
            this.id_produto = idpro;
            this.valor = v;
            this.qtd = qtd;
            this.tstamp = ts;
        }

    }
}
