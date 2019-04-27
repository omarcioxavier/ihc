using System.Collections.Generic;

namespace colorcom.Models.Localizacao
{
    public class estado
    {
        //TABELA
        public int es_cod { get; set; }

        public string es_nome { get; set; }

        public string es_uf { get; set; }

        //OBJETOS
        public ICollection<cidade> cidades { get; set; }
    }
}