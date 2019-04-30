using colorcom.Models.Emitente;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.Localizacao
{
    [Table("cidade")]
    public class cidade
    {
        //TABELA
        [Key]
        public int ci_cod { get; set; }

        [MaxLength(100)]
        public string ci_nome { get; set; }

        [Required]
        public int ci_es_cod { get; set; }

        //OBJETOS
        public virtual estado estados { get; set; }

        public ICollection<emitente> emitentes { get; set; }
    }
}