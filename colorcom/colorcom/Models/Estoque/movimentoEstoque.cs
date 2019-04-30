using colorcom.Models.Item;
using colorcom.Models.NotaFiscal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.Estoque
{
    [Table("movimentoEstoque")]
    public class movimentoEstoque
    {
        //TABELA
        [Key]
        public int me_cod { get; set; }

        [Required]
        public int me_it_cod { get; set; }

        [Required]
        public int me_sn_cod { get; set; }

        [Required]
        public int me_en_cod { get; set; }

        //OBJETOS
        public item item { get; set; }

        public saidaNF saidaNF { get; set; }

        public entradaNF entradaNF { get; set; }
    }
}