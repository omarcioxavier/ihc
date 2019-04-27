using colorcom.Models.Item;

namespace colorcom.Models.Pedidos
{
    public class itensPedido
    {
        //TABELA
        public int ip_cod { get; set; }

        public float ip_valor { get; set; }

        public string ip_descricao { get; set; }

        public int ip_quantidade { get; set; }

        public int ip_it_cod { get; set; }

        //OBJETOS
        public item item { get; set; }
    }
}