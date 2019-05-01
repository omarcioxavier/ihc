﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.Item
{
    [Table("categoria")]
    public class categoria
    {
        [Key]
        public int ca_cod { get; set; }

        [MaxLength(100)]
        public string ca_descricao { get; set; }

        public int ca_ca_cod { get; set; }

        [ForeignKey("ca_ca_cod")]
        public virtual categoria Categoria { get; set; }

        public virtual ICollection<item> itens { get; set; }

        public virtual ICollection<categoria> categorias { get; set; }
    }
}