namespace Trabalho_Rogerio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        ContasId = c.Int(nullable: false, identity: true),
                        Fornecedor = c.String(maxLength: 50),
                        Dtvencimento = c.DateTime(nullable: false),
                        Dtpagamento = c.DateTime(nullable: false),
                        Pago = c.Boolean(nullable: false),
                        Descricao = c.String(maxLength: 100),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ContasId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contas");
        }
    }
}
