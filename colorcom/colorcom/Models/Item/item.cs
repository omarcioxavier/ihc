using colorcom.Models.Estoque;
using System.Collections.Generic;

namespace colorcom.Models.Item
{
    public class item
    {
        //TABELA
        public int it_cod { get; set; }

        public string ti_titulo { get; set; }

        public string it_descricao { get; set; }

        public string it_ean { get; set; }

        public float it_preco_compra { get; set; }

        public float it_preco_venda { get; set; }

        public int it_min { get; set; }

        public int it_max { get; set; }

        public int it_quantidade { get; set; }

        public bool it_status { get; set; }

        public int it_ca_cod { get; set; }

        public int it_um_cod { get; set; }

        //OBJETOS
        public categoria categoria { get; set; }

        public unidadeMedida unidade_medida { get; set; }

        public ICollection<logItem> logsItem { get; set; }

        public ICollection<movimentoEstoque> movimentosEstoque { get; set; }
    }
}