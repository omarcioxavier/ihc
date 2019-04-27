using System.Collections.Generic;

namespace colorcom.Models.Item
{
    public class unidadeMedida
    {
        //TABELA
        public int um_cod { get; set; }

        public string um_sigla { get; set; }

        public string um_descricao { get; set; }

        //OBJETOS
        public ICollection<item> itens { get; set; }
    }
}