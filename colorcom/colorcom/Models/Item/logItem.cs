using System;

namespace colorcom.Models.Item
{
    public class logItem
    {
        //TABELA
        public int li_cod { get; set; }

        public float li_preco_novo { get; set; }

        public DateTime li_dataHora { get; set; }

        public int li_it_cod { get; set; }

        //OBJETOS
        public item item { get; set; }
    }
}