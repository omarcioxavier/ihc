using colorcom.Models.Emitente;
using colorcom.Models.Estoque;
using colorcom.Models.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.NotaFiscal
{
    [Table("entradaNF")]
    public class entradaNF
    {
        //TABELA
        [Key]
        public int en_cod { get; set; }

        public int en_numero { get; set; }

        public int en_serie { get; set; }

        public DateTime en_dataEntrada { get; set; }

        public DateTime en_dataEmissao { get; set; }

        [MaxLength(100)]
        public string en_endereco { get; set; }

        [Required]
        public int en_us_cod { get; set; }

        [Required]
        public int en_em_cod { get; set; }

        [Required]
        public int en_ci_cod { get; set; }

        //OBJETOS
        public usuario usuario { get; set; }

        public emitente emitente { get; set; }

        public ICollection<movimentoEstoque> moviemntosEstoque { get; set; }
    }
}