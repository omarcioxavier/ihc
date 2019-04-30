using colorcom.Models.Estoque;
using colorcom.Models.Pedidos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.NotaFiscal
{
    [Table("saidaNF")]
    public class saidaNF
    {
        //TABELA
        [Key]
        public int sn_cod { get; set; }

        public int sn_numero { get; set; }

        public int sn_serie { get; set; }

        [Required]
        public int sn_pe_cod { get; set; }

        //OBJETOS
        public pedido pedido { get; set; }

        public ICollection<movimentoEstoque> movimentosEstoque { get; set; }
    }
}