namespace colorcom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tipoUsuario",
                c => new
                {
                    tu_cod = c.Int(nullable: false, identity: true),
                    tu_descricao = c.String(maxLength: 100),
                })
                .PrimaryKey(t => t.tu_cod);

            CreateTable(
                "dbo.usuario",
                c => new
                {
                    us_cod = c.Int(nullable: false, identity: true),
                    us_login = c.String(maxLength: 100),
                    us_senha = c.String(maxLength: 100),
                    us_status = c.Boolean(nullable: false),
                    us_tu_cod = c.Int(nullable: false),
                    tipoUsuario_tu_cod = c.Int(),
                })
                .PrimaryKey(t => t.us_cod)
                .ForeignKey("dbo.tipoUsuario", t => t.tipoUsuario_tu_cod)
                .Index(t => t.us_login, unique: true)
                .Index(t => t.tipoUsuario_tu_cod);

            CreateTable(
                "dbo.estado",
                c => new
                {
                    es_cod = c.Int(nullable: false, identity: true),
                    es_nome = c.String(maxLength: 100),
                    es_uf = c.String(maxLength: 2),
                })
                .PrimaryKey(t => t.es_cod);

            CreateTable(
                "dbo.cidade",
                c => new
                {
                    ci_cod = c.Int(nullable: false, identity: true),
                    ci_nome = c.String(maxLength: 100),
                    ci_es_cod = c.Int(nullable: false),
                    estados_es_cod = c.Int(),
                })
                .PrimaryKey(t => t.ci_cod)
                .ForeignKey("dbo.estado", t => t.estados_es_cod)
                .Index(t => t.estados_es_cod);

            CreateTable(
                "dbo.tipoEmitente",
                c => new
                {
                    te_cod = c.Int(nullable: false, identity: true),
                    te_descricao = c.String(maxLength: 100),
                })
                .PrimaryKey(t => t.te_cod);

            CreateTable(
                "dbo.emitente",
                c => new
                {
                    em_cod = c.Int(nullable: false, identity: true),
                    em_nome = c.String(maxLength: 100),
                    em_nomeFantasia = c.String(maxLength: 100),
                    em_documento = c.String(maxLength: 18),
                    em_endereco = c.String(maxLength: 100),
                    em_telefone = c.String(maxLength: 14),
                    em_celular = c.String(maxLength: 14),
                    em_email = c.String(maxLength: 100),
                    em_status = c.Boolean(nullable: false),
                    em_inscricaoEstadual = c.String(maxLength: 20),
                    em_te_cod = c.Int(nullable: false),
                    em_ci_cod = c.Int(nullable: false),
                    cidade_ci_cod = c.Int(),
                    tipoEmitente_te_cod = c.Int(),
                })
                .PrimaryKey(t => t.em_cod)
                .ForeignKey("dbo.cidade", t => t.cidade_ci_cod)
                .ForeignKey("dbo.tipoEmitente", t => t.tipoEmitente_te_cod)
                .Index(t => t.em_documento, unique: true)
                .Index(t => t.em_inscricaoEstadual, unique: true)
                .Index(t => t.cidade_ci_cod)
                .Index(t => t.tipoEmitente_te_cod);

            CreateTable(
                "dbo.unidadeMedida",
                c => new
                {
                    um_cod = c.Int(nullable: false, identity: true),
                    um_sigla = c.String(maxLength: 10),
                    um_descricao = c.String(maxLength: 100),
                })
                .PrimaryKey(t => t.um_cod);

            CreateTable(
                "dbo.entradaNF",
                c => new
                {
                    en_cod = c.Int(nullable: false, identity: true),
                    en_numero = c.Int(nullable: false),
                    en_serie = c.Int(nullable: false),
                    en_dataEntrada = c.DateTime(nullable: false),
                    en_dataEmissao = c.DateTime(nullable: false),
                    en_endereco = c.String(maxLength: 100),
                    en_us_cod = c.Int(nullable: false),
                    en_em_cod = c.Int(nullable: false),
                    en_ci_cod = c.Int(nullable: false),
                    emitente_em_cod = c.Int(),
                    usuario_us_cod = c.Int(),
                })
                .PrimaryKey(t => t.en_cod)
                .ForeignKey("dbo.emitente", t => t.emitente_em_cod)
                .ForeignKey("dbo.usuario", t => t.usuario_us_cod)
                .Index(t => t.emitente_em_cod)
                .Index(t => t.usuario_us_cod);

            CreateTable(
                "dbo.categoria",
                c => new
                {
                    ca_cod = c.Int(nullable: false, identity: true),
                    ca_descricao = c.String(maxLength: 100),
                    ca_cod_subcategoria = c.Int(nullable: false),
                    Categoria_ca_cod = c.Int(),
                })
                .PrimaryKey(t => t.ca_cod)
                .ForeignKey("dbo.categoria", t => t.Categoria_ca_cod)
                .Index(t => t.Categoria_ca_cod);

            CreateTable(
               "dbo.item",
               c => new
               {
                   it_cod = c.Int(nullable: false, identity: true),
                   ti_titulo = c.String(maxLength: 100),
                   it_descricao = c.String(maxLength: 100),
                   it_ean = c.String(maxLength: 100),
                   it_preco_compra = c.Single(nullable: false),
                   it_preco_venda = c.Single(nullable: false),
                   it_min = c.Int(nullable: false),
                   it_max = c.Int(nullable: false),
                   it_quantidade = c.Int(nullable: false),
                   it_status = c.Boolean(nullable: false),
                   it_ca_cod = c.Int(nullable: false),
                   it_um_cod = c.Int(nullable: false),
                   categoria_ca_cod = c.Int(),
                   unidadeMedida_um_cod = c.Int(),
               })
               .PrimaryKey(t => t.it_cod)
               .ForeignKey("dbo.categoria", t => t.categoria_ca_cod)
               .ForeignKey("dbo.unidadeMedida", t => t.unidadeMedida_um_cod)
               .Index(t => t.it_ean, unique: true)
               .Index(t => t.categoria_ca_cod)
               .Index(t => t.unidadeMedida_um_cod);

            CreateTable(
                "dbo.itensPedido",
                c => new
                {
                    ip_cod = c.Int(nullable: false, identity: true),
                    ip_valor = c.Single(nullable: false),
                    ip_descricao = c.String(nullable: false),
                    ip_quantidade = c.Int(nullable: false),
                    ip_it_cod = c.Int(nullable: false),
                    item_it_cod = c.Int(),
                })
                .PrimaryKey(t => t.ip_cod)
                .ForeignKey("dbo.item", t => t.item_it_cod)
                .Index(t => t.item_it_cod);

            CreateTable(
                "dbo.logItem",
                c => new
                {
                    li_cod = c.Int(nullable: false, identity: true),
                    li_preco_novo = c.Single(nullable: false),
                    li_dataHora = c.DateTime(nullable: false),
                    li_it_cod = c.Int(nullable: false),
                    item_it_cod = c.Int(),
                })
                .PrimaryKey(t => t.li_cod)
                .ForeignKey("dbo.item", t => t.item_it_cod)
                .Index(t => t.item_it_cod);

            CreateTable(
                "dbo.pedido",
                c => new
                {
                    pe_cod = c.Int(nullable: false, identity: true),
                    pe_valor = c.Single(nullable: false),
                    pe_dataHora = c.DateTime(nullable: false),
                    pe_us_cod = c.Int(nullable: false),
                    pe_em_cod = c.Int(nullable: false),
                    pe_ip_cod = c.Int(nullable: false),
                    emitente_em_cod = c.Int(),
                    itensPedido_ip_cod = c.Int(),
                    usuario_us_cod = c.Int(),
                })
                .PrimaryKey(t => t.pe_cod)
                .ForeignKey("dbo.emitente", t => t.emitente_em_cod)
                .ForeignKey("dbo.itensPedido", t => t.itensPedido_ip_cod)
                .ForeignKey("dbo.usuario", t => t.usuario_us_cod)
                .Index(t => t.emitente_em_cod)
                .Index(t => t.itensPedido_ip_cod)
                .Index(t => t.usuario_us_cod);

            CreateTable(
                "dbo.saidaNF",
                c => new
                {
                    sn_cod = c.Int(nullable: false, identity: true),
                    sn_numero = c.Int(nullable: false),
                    sn_serie = c.Int(nullable: false),
                    sn_pe_cod = c.Int(nullable: false),
                    pedido_pe_cod = c.Int(),
                })
                .PrimaryKey(t => t.sn_cod)
                .ForeignKey("dbo.pedido", t => t.pedido_pe_cod)
                .Index(t => t.pedido_pe_cod);

            CreateTable(
                "dbo.movimentoEstoque",
                c => new
                {
                    me_cod = c.Int(nullable: false, identity: true),
                    me_it_cod = c.Int(nullable: false),
                    me_sn_cod = c.Int(nullable: false),
                    me_en_cod = c.Int(nullable: false),
                    entradaNF_en_cod = c.Int(),
                    item_it_cod = c.Int(),
                    saidaNF_sn_cod = c.Int(),
                })
                .PrimaryKey(t => t.me_cod)
                .ForeignKey("dbo.entradaNF", t => t.entradaNF_en_cod)
                .ForeignKey("dbo.item", t => t.item_it_cod)
                .ForeignKey("dbo.saidaNF", t => t.saidaNF_sn_cod)
                .Index(t => t.entradaNF_en_cod)
                .Index(t => t.item_it_cod)
                .Index(t => t.saidaNF_sn_cod);
        }

        public override void Down()
        {
            DropForeignKey("dbo.cidade", "estados_es_cod", "dbo.estado");
            DropForeignKey("dbo.emitente", "tipoEmitente_te_cod", "dbo.tipoEmitente");
            DropForeignKey("dbo.saidaNF", "pedido_pe_cod", "dbo.pedido");
            DropForeignKey("dbo.usuario", "tipoUsuario_tu_cod", "dbo.tipoUsuario");
            DropForeignKey("dbo.pedido", "usuario_us_cod", "dbo.usuario");
            DropForeignKey("dbo.entradaNF", "usuario_us_cod", "dbo.usuario");
            DropForeignKey("dbo.pedido", "itensPedido_ip_cod", "dbo.itensPedido");
            DropForeignKey("dbo.itensPedido", "item_it_cod", "dbo.item");
            DropForeignKey("dbo.pedido", "emitente_em_cod", "dbo.emitente");
            DropForeignKey("dbo.movimentoEstoque", "saidaNF_sn_cod", "dbo.saidaNF");
            DropForeignKey("dbo.item", "unidadeMedida_um_cod", "dbo.unidadeMedida");
            DropForeignKey("dbo.movimentoEstoque", "item_it_cod", "dbo.item");
            DropForeignKey("dbo.logItem", "item_it_cod", "dbo.item");
            DropForeignKey("dbo.item", "categoria_ca_cod", "dbo.categoria");
            DropForeignKey("dbo.categoria", "Categoria_ca_cod", "dbo.categoria");
            DropForeignKey("dbo.movimentoEstoque", "entradaNF_en_cod", "dbo.entradaNF");
            DropForeignKey("dbo.entradaNF", "emitente_em_cod", "dbo.emitente");
            DropForeignKey("dbo.emitente", "cidade_ci_cod", "dbo.cidade");
            DropIndex("dbo.usuario", new[] { "tipoUsuario_tu_cod" });
            DropIndex("dbo.usuario", new[] { "us_login" });
            DropIndex("dbo.itensPedido", new[] { "item_it_cod" });
            DropIndex("dbo.pedido", new[] { "usuario_us_cod" });
            DropIndex("dbo.pedido", new[] { "itensPedido_ip_cod" });
            DropIndex("dbo.pedido", new[] { "emitente_em_cod" });
            DropIndex("dbo.saidaNF", new[] { "pedido_pe_cod" });
            DropIndex("dbo.logItem", new[] { "item_it_cod" });
            DropIndex("dbo.categoria", new[] { "Categoria_ca_cod" });
            DropIndex("dbo.item", new[] { "unidadeMedida_um_cod" });
            DropIndex("dbo.item", new[] { "categoria_ca_cod" });
            DropIndex("dbo.item", new[] { "it_ean" });
            DropIndex("dbo.movimentoEstoque", new[] { "saidaNF_sn_cod" });
            DropIndex("dbo.movimentoEstoque", new[] { "item_it_cod" });
            DropIndex("dbo.movimentoEstoque", new[] { "entradaNF_en_cod" });
            DropIndex("dbo.entradaNF", new[] { "usuario_us_cod" });
            DropIndex("dbo.entradaNF", new[] { "emitente_em_cod" });
            DropIndex("dbo.emitente", new[] { "tipoEmitente_te_cod" });
            DropIndex("dbo.emitente", new[] { "cidade_ci_cod" });
            DropIndex("dbo.emitente", new[] { "em_inscricaoEstadual" });
            DropIndex("dbo.emitente", new[] { "em_documento" });
            DropIndex("dbo.cidade", new[] { "estados_es_cod" });
            DropTable("dbo.estado");
            DropTable("dbo.tipoEmitente");
            DropTable("dbo.tipoUsuario");
            DropTable("dbo.usuario");
            DropTable("dbo.itensPedido");
            DropTable("dbo.pedido");
            DropTable("dbo.saidaNF");
            DropTable("dbo.unidadeMedida");
            DropTable("dbo.logItem");
            DropTable("dbo.categoria");
            DropTable("dbo.item");
            DropTable("dbo.movimentoEstoque");
            DropTable("dbo.entradaNF");
            DropTable("dbo.emitente");
            DropTable("dbo.cidade");
        }
    }
}
