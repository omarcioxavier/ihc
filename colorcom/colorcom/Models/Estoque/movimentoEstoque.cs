using colorcom.Models.Item;
using colorcom.Models.NotaFiscal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.Estoque
{
    [Table("movimentoEstoque")]
    public class movimentoEstoque
    {
        [Key]
        public int me_cod { get; set; }

        public item me_it_cod { get; set; }

        public saidaNF me_sn_cod { get; set; }

        public entradaNF me_en_cod { get; set; }
    }
}