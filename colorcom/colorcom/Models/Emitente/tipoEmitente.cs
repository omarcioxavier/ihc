using colorcom.Models.Emitente;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.Usuario
{
    [Table("tipoEmitente")]
    public class tipoEmitente
    {
        //TABELA
        [Key]
        public int te_cod { get; set; }

        [MaxLength(100)]
        public string te_descricao { get; set; }

        //OBJETOS
        public ICollection<emitente> emitentes { get; set; }
    }
}