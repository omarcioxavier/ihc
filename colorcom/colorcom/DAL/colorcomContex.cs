using colorcom.Models.Emitente;
using colorcom.Models.Estoque;
using colorcom.Models.Item;
using colorcom.Models.Localizacao;
using colorcom.Models.NotaFiscal;
using colorcom.Models.Pedidos;
using colorcom.Models.Usuario;
using System.Data.Entity;

namespace colorcom.DAL
{
    public class colorcomContex : DbContext
    {
        //Construtor que chama minha string de conexão do web.config
        public colorcomContex() : base("colorcomcnnstr") { }

        //Construtor para a classe
        public static colorcomContex Create()
        {
            return new colorcomContex();
        }

        //Tabelas
        public DbSet<cidade> cidades { get; set; }
        public DbSet<emitente> emitentes { get; set; }
        public DbSet<entradaNF> entradasNF { get; set; }
        public DbSet<estado> estados { get; set; }
        public DbSet<item> itens { get; set; }
        public DbSet<itensPedido> itensPedido { get; set; }
        public DbSet<logItem> logsItens { get; set; }
        public DbSet<movimentoEstoque> movimentosEstoque { get; set; }
        public DbSet<pedido> pedidos { get; set; }
        public DbSet<saidaNF> saidasNF { get; set; }
        public DbSet<tipoEmitente> tiposEmitente { get; set; }
        public DbSet<tipoUsuario> tiposUsuarios { get; set; }
        public DbSet<unidadeMedida> unidadesMedida { get; set; }
        public DbSet<usuario> usuarios { get; set; }
    }
}