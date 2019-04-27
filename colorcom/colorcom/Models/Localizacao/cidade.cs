using colorcom.Models.Emitente;
using System.Collections.Generic;

namespace colorcom.Models.Localizacao
{
    public class cidade
    {
        //TABELA
        public int ci_cod { get; set; }

        public string name { get; set; }

        public int es_cod { get; set; }

        //OBJETOS
        public virtual estado estados { get; set; }

        public ICollection<emitente> emitentes { get; set; }
    }
}