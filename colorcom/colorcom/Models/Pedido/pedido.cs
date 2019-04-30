using colorcom.Models.Emitente;
using colorcom.Models.Usuario;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.Pedidos
{
    [Table("pedido")]
    public class pedido
    {
        //TABELA
        [Key]
        public int pe_cod { get; set; }

        public float pe_valor { get; set; }

        public DateTime pe_dataHora { get; set; }

        [Required]
        public int pe_us_cod { get; set; }

        [Required]
        public int pe_em_cod { get; set; }

        [Required]
        public int pe_ip_cod { get; set; }

        //OBJETOS
        public usuario usuario { get; set; }

        public emitente emitente { get; set; }

        public itensPedido itensPedido { get; set; }
    }
}