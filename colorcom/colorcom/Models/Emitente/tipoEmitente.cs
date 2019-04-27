using colorcom.Models.Emitente;
using System.Collections.Generic;

namespace colorcom.Models.Usuario
{
    public class tipoEmitente
    {
        //TABELA
        public int te_cod { get; set; }

        public string te_descricao { get; set; }

        //OBJETOS
        public ICollection<emitente> emitentes { get; set; }
    }
}