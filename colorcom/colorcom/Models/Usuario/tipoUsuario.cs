using System.Collections.Generic;

namespace colorcom.Models.Usuario
{
    public class tipoUsuario
    {
        //TABELA
        public int tu_cod { get; set; }

        public string tu_descricao { get; set; }

        //OBJETOS
        public ICollection<usuario> usuarios { get; set; }
    }
}