using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.Item
{
    [Table("categoria")]
    public class categoria
    {
        //TABELA
        [Key]
        public int ca_cod { get; set; }

        [MaxLength(100)]
        public string ca_descricao { get; set; }

        [Required]
        public int ca_cod_subcategoria { get; set; }

        //OBJETOS
        public categoria Categoria { get; set; }

        public ICollection<item> itens { get; set; }

        public ICollection<categoria> subcategorias { get; set; }
    }
}