using colorcom.Models.Item;
using colorcom.Models.NotaFiscal;

namespace colorcom.Models.Estoque
{
    public class movimentoEstoque
    {
        //TABELA
        public int me_cod { get; set; }

        public int me_it_cod { get; set; }

        public int me_sn_cod { get; set; }

        public int me_en_cod { get; set; }

        //OBJETOS
        public item item { get; set; }

        public saidaNF saidaNF { get; set; }

        public entradaNF entradaNF { get; set; }
    }
}