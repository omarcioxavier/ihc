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
        [Key]
        public int pe_cod { get; set; }

        public float pe_valor { get; set; }

        public DateTime pe_dataHora { get; set; }

        public usuario pe_us_cod { get; set; }

        public emitente pe_em_cod { get; set; }

        public itensPedido pe_ip_cod { get; set; }
    }
}