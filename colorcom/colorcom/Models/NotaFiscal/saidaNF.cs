using colorcom.Models.Estoque;
using colorcom.Models.Pedidos;
using System.Collections.Generic;

namespace colorcom.Models.NotaFiscal
{
    public class saidaNF
    {
        //TABELA
        public int sn_cod { get; set; }

        public int sn_serie { get; set; }

        public int sn_pe_cod { get; set; }

        //OBJETOS
        public pedido pedido { get; set; }

        public ICollection<movimentoEstoque> movimentosEstoque { get; set; }
    }
}