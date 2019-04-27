using System.Collections.Generic;

namespace colorcom.Models.Item
{
    public class categoria
    {
        //TABELA
        public int ca_cod { get; set; }

        public string ca_descricao { get; set; }

        public int ca_cod_subcategoria { get; set; }

        //OBJETOS
        public categoria Categoria { get; set; }

        public ICollection<item> itens { get; set; }

        public ICollection<categoria> subcategorias { get; set; }
    }
}