using colorcom.Models.Localizacao;
using colorcom.Models.NotaFiscal;
using colorcom.Models.Pedidos;
using colorcom.Models.Usuario;
using System.Collections.Generic;

namespace colorcom.Models.Emitente
{
    public class emitente
    {
        //TABELA
        public int em_cod { get; set; }

        public string em_nome { get; set; }

        public string em_nomeFantasia { get; set; }

        public string em_documento { get; set; }

        public string em_endereco { get; set; }

        public string em_telefone { get; set; }

        public string em_celular { get; set; }

        public string em_email { get; set; }

        public bool em_status { get; set; }

        public string em_inscricaoEstadual { get; set; }

        public int em_te_cod { get; set; }

        public int em_ci_cod { get; set; }

        //OBJETOS
        public cidade cidade { get; set; }

        public tipoEmitente tipoEmitente { get; set; }

        public ICollection<pedido> pedidos { get; set; }

        public ICollection<entradaNF> entradasNF { get; set; }
    }
}