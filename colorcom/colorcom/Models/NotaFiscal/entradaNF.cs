using colorcom.Models.Emitente;
using colorcom.Models.Estoque;
using colorcom.Models.Usuario;
using System;
using System.Collections.Generic;

namespace colorcom.Models.NotaFiscal
{
    public class entradaNF
    {
        //TABELA
        public int en_cod { get; set; }

        public int en_numero { get; set; }

        public int en_serie { get; set; }

        public DateTime en_dataEntrada { get; set; }

        public DateTime en_dataEmissao { get; set; }

        public string en_rua { get; set; }

        public string en_numeroEndereco { get; set; }

        public string en_bairro { get; set; }

        public string en_cep { get; set; }

        public int en_us_cod { get; set; }

        public int en_em_cod { get; set; }

        //OBJETOS
        public usuario usuario { get; set; }

        public emitente emitente { get; set; }

        public ICollection<movimentoEstoque> moviemntosEstoque { get; set; }
    }
}