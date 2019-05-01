namespace colorcom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialMigration : DbMigration
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
                    us_tu_cod = c.Int(),
                })
                .PrimaryKey(t => t.us_cod)
                .ForeignKey("dbo.tipoUsuario", t => t.us_tu_cod)
                .Index(t => t.us_login, unique: true)
                .Index(t => t.us_tu_cod);

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
                    ci_es_cod = c.Int(),
                })
                .PrimaryKey(t => t.ci_cod)
                .ForeignKey("dbo.estado", t => t.ci_es_cod)
                .Index(t => t.ci_es_cod);

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
                    em_ci_cod = c.Int(),
                    em_te_cod = c.Int(),
                })
                .PrimaryKey(t => t.em_cod)
                .ForeignKey("dbo.cidade", t => t.em_ci_cod)
                .ForeignKey("dbo.tipoEmitente", t => t.em_te_cod)
                .Index(t => t.em_documento, unique: true)
                .Index(t => t.em_inscricaoEstadual, unique: true)
                .Index(t => t.em_ci_cod)
                .Index(t => t.em_te_cod);

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
                    en_ci_cod = c.Int(),
                    en_em_cod = c.Int(),
                    en_us_cod = c.Int(),
                })
                .PrimaryKey(t => t.en_cod)
                .ForeignKey("dbo.cidade", t => t.en_ci_cod)
                .ForeignKey("dbo.emitente", t => t.en_em_cod)
                .ForeignKey("dbo.usuario", t => t.en_us_cod)
                .Index(t => t.en_ci_cod)
                .Index(t => t.en_em_cod)
                .Index(t => t.en_us_cod);

            CreateTable(
                "dbo.categoria",
                c => new
                {
                    ca_cod = c.Int(nullable: false, identity: true),
                    ca_descricao = c.String(maxLength: 100),
                    ca_cod_ca = c.Int(),
                })
                .PrimaryKey(t => t.ca_cod)
                .ForeignKey("dbo.categoria", t => t.ca_cod_ca)
                .Index(t => t.ca_cod_ca);

            CreateTable(
              "dbo.item",
              c => new
              {
                  it_cod = c.Int(nullable: false, identity: true),
                  it_titulo = c.String(maxLength: 100),
                  it_descricao = c.String(maxLength: 100),
                  it_ean = c.String(maxLength: 100),
                  it_preco_compra = c.Single(nullable: false),
                  it_preco_venda = c.Single(nullable: false),
                  it_min = c.Int(nullable: false),
                  it_max = c.Int(nullable: false),
                  it_quantidade = c.Int(nullable: false),
                  it_status = c.Boolean(nullable: false),
                  it_ca_cod = c.Int(),
                  it_um_cod = c.Int(),
              })
              .PrimaryKey(t => t.it_cod)
              .ForeignKey("dbo.categoria", t => t.it_ca_cod)
              .ForeignKey("dbo.unidadeMedida", t => t.it_um_cod)
              .Index(t => t.it_ean, unique: true)
              .Index(t => t.it_ca_cod)
              .Index(t => t.it_um_cod);

            CreateTable(
                "dbo.itensPedido",
                c => new
                {
                    ip_cod = c.Int(nullable: false, identity: true),
                    ip_valor = c.Single(nullable: false),
                    ip_descricao = c.String(nullable: false),
                    ip_quantidade = c.Int(nullable: false),
                    ip_it_cod = c.Int(),
                })
                .PrimaryKey(t => t.ip_cod)
                .ForeignKey("dbo.item", t => t.ip_it_cod)
                .Index(t => t.ip_it_cod);

            CreateTable(
                "dbo.logItem",
                c => new
                {
                    li_cod = c.Int(nullable: false, identity: true),
                    li_preco_novo = c.Single(nullable: false),
                    li_dataHora = c.DateTime(nullable: false),
                    li_it_cod = c.Int(),
                })
                .PrimaryKey(t => t.li_cod)
                .ForeignKey("dbo.item", t => t.li_it_cod)
                .Index(t => t.li_it_cod);

            CreateTable(
                "dbo.pedido",
                c => new
                {
                    pe_cod = c.Int(nullable: false, identity: true),
                    pe_valor = c.Single(nullable: false),
                    pe_dataHora = c.DateTime(nullable: false),
                    pe_em_cod = c.Int(),
                    pe_ip_cod = c.Int(),
                    pe_us_cod = c.Int(),
                })
                .PrimaryKey(t => t.pe_cod)
                .ForeignKey("dbo.emitente", t => t.pe_em_cod)
                .ForeignKey("dbo.itensPedido", t => t.pe_ip_cod)
                .ForeignKey("dbo.usuario", t => t.pe_us_cod)
                .Index(t => t.pe_em_cod)
                .Index(t => t.pe_ip_cod)
                .Index(t => t.pe_us_cod);

            CreateTable(
                "dbo.saidaNF",
                c => new
                {
                    sn_cod = c.Int(nullable: false, identity: true),
                    sn_numero = c.Int(nullable: false),
                    sn_serie = c.Int(nullable: false),
                    sn_pe_cod = c.Int(),
                })
                .PrimaryKey(t => t.sn_cod)
                .ForeignKey("dbo.pedido", t => t.sn_pe_cod)
                .Index(t => t.sn_pe_cod);

            CreateTable(
                "dbo.movimentoEstoque",
                c => new
                {
                    me_cod = c.Int(nullable: false, identity: true),
                    me_en_cod = c.Int(),
                    me_it_cod = c.Int(),
                    me_sn_cod = c.Int(),
                })
                .PrimaryKey(t => t.me_cod)
                .ForeignKey("dbo.entradaNF", t => t.me_en_cod)
                .ForeignKey("dbo.item", t => t.me_it_cod)
                .ForeignKey("dbo.saidaNF", t => t.me_sn_cod)
                .Index(t => t.me_en_cod)
                .Index(t => t.me_it_cod)
                .Index(t => t.me_sn_cod);
        }

        public override void Down()
        {
            DropForeignKey("dbo.usuario", "us_tu_cod_tu_cod", "dbo.tipoUsuario");
            DropForeignKey("dbo.pedido", "pe_us_cod_us_cod", "dbo.usuario");
            DropForeignKey("dbo.pedido", "pe_ip_cod_ip_cod", "dbo.itensPedido");
            DropForeignKey("dbo.itensPedido", "ip_it_cod_it_cod", "dbo.item");
            DropForeignKey("dbo.saidaNF", "sn_pe_cod_pe_cod", "dbo.pedido");
            DropForeignKey("dbo.movimentoEstoque", "me_sn_cod_sn_cod", "dbo.saidaNF");
            DropForeignKey("dbo.movimentoEstoque", "me_it_cod_it_cod", "dbo.item");
            DropForeignKey("dbo.movimentoEstoque", "me_en_cod_en_cod", "dbo.entradaNF");
            DropForeignKey("dbo.logItem", "li_it_cod_it_cod", "dbo.item");
            DropForeignKey("dbo.item", "it_um_cod_um_cod", "dbo.unidadeMedida");
            DropForeignKey("dbo.item", "it_ca_cod_ca_cod", "dbo.categoria");
            DropForeignKey("dbo.categoria", "ca_cod_ca_ca_cod", "dbo.categoria");
            DropForeignKey("dbo.pedido", "pe_em_cod_em_cod", "dbo.emitente");
            DropForeignKey("dbo.entradaNF", "en_us_cod_us_cod", "dbo.usuario");
            DropForeignKey("dbo.entradaNF", "en_em_cod_em_cod", "dbo.emitente");
            DropForeignKey("dbo.entradaNF", "en_ci_cod_ci_cod", "dbo.cidade");
            DropForeignKey("dbo.emitente", "em_te_cod_te_cod", "dbo.tipoEmitente");
            DropForeignKey("dbo.emitente", "em_ci_cod_ci_cod", "dbo.cidade");
            DropForeignKey("dbo.cidade", "ci_es_cod_es_cod", "dbo.estado");
            DropIndex("dbo.saidaNF", new[] { "sn_pe_cod_pe_cod" });
            DropIndex("dbo.movimentoEstoque", new[] { "me_sn_cod_sn_cod" });
            DropIndex("dbo.movimentoEstoque", new[] { "me_it_cod_it_cod" });
            DropIndex("dbo.movimentoEstoque", new[] { "me_en_cod_en_cod" });
            DropIndex("dbo.logItem", new[] { "li_it_cod_it_cod" });
            DropIndex("dbo.categoria", new[] { "ca_cod_ca_ca_cod" });
            DropIndex("dbo.item", new[] { "it_um_cod_um_cod" });
            DropIndex("dbo.item", new[] { "it_ca_cod_ca_cod" });
            DropIndex("dbo.item", new[] { "it_ean" });
            DropIndex("dbo.itensPedido", new[] { "ip_it_cod_it_cod" });
            DropIndex("dbo.pedido", new[] { "pe_us_cod_us_cod" });
            DropIndex("dbo.pedido", new[] { "pe_ip_cod_ip_cod" });
            DropIndex("dbo.pedido", new[] { "pe_em_cod_em_cod" });
            DropIndex("dbo.usuario", new[] { "us_tu_cod_tu_cod" });
            DropIndex("dbo.usuario", new[] { "us_login" });
            DropIndex("dbo.entradaNF", new[] { "en_us_cod_us_cod" });
            DropIndex("dbo.entradaNF", new[] { "en_em_cod_em_cod" });
            DropIndex("dbo.entradaNF", new[] { "en_ci_cod_ci_cod" });
            DropIndex("dbo.emitente", new[] { "em_te_cod_te_cod" });
            DropIndex("dbo.emitente", new[] { "em_ci_cod_ci_cod" });
            DropIndex("dbo.emitente", new[] { "em_inscricaoEstadual" });
            DropIndex("dbo.emitente", new[] { "em_documento" });
            DropIndex("dbo.cidade", new[] { "ci_es_cod_es_cod" });
            DropTable("dbo.tipoUsuario");
            DropTable("dbo.saidaNF");
            DropTable("dbo.movimentoEstoque");
            DropTable("dbo.logItem");
            DropTable("dbo.unidadeMedida");
            DropTable("dbo.categoria");
            DropTable("dbo.item");
            DropTable("dbo.itensPedido");
            DropTable("dbo.pedido");
            DropTable("dbo.usuario");
            DropTable("dbo.entradaNF");
            DropTable("dbo.tipoEmitente");
            DropTable("dbo.emitente");
            DropTable("dbo.estado");
            DropTable("dbo.cidade");
        }
    }
}
