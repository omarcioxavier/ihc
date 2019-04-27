using colorcom.Models.NotaFiscal;
using colorcom.Models.Pedidos;
using System.Collections.Generic;

namespace colorcom.Models.Usuario
{
    public class usuario
    {
        //TABELA
        public int us_cod { get; set; }

        public string us_login { get; set; }

        public string us_senha { get; set; }

        public bool us_status { get; set; }

        public int us_tu_cod { get; set; }

        //OBJETOS

        public tipoUsuario tipoUsuario { get; set; }

        public ICollection<pedido> pedidos { get; set; }

        public ICollection<entradaNF> entradasNF { get; set; }
    }
}