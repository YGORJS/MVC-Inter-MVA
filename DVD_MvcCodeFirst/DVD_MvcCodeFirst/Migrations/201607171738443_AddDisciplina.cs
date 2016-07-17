namespace DVD_MvcCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDisciplina : DbMigration
    {
        public override void Up()
        {

            /*
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        IDAluno = c.Int(nullable: false, identity: true),
                        IDProfessor = c.Int(nullable: false),
                        NomeAluno = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 250),
                        Ano = c.Int(nullable: false),
                        Aprovado = c.Boolean(nullable: false),
                        Inscricao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IDAluno)
                .ForeignKey("dbo.Professor", t => t.IDProfessor, cascadeDelete: true)
                .Index(t => t.IDProfessor);
                
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        IDProfessor = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        ContatoDigital = c.String(),
                        Telefone = c.String(),
                        Salario = c.Decimal(precision: 18, scale: 2),
                        Materia = c.String(),
                        Disponivel = c.Boolean(nullable: false),
                        Admissao = c.DateTime(),
                    })
                .PrimaryKey(t => t.IDProfessor);
            */
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        IDDisciplina = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Descricao = c.String(),
                        IDProfessor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDDisciplina)
                .ForeignKey("dbo.Professor", t => t.IDProfessor, cascadeDelete: true)
                .Index(t => t.IDProfessor);
            
            /*
            CreateTable(
                "dbo.Topico",
                c => new
                    {
                        IDTopico = c.Int(nullable: false, identity: true),
                        IDProfessor = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.IDTopico)
                .ForeignKey("dbo.Professor", t => t.IDProfessor, cascadeDelete: true)
                .Index(t => t.IDProfessor);
                */
            
        }
        
        public override void Down()
        {

           // DropTable("dbo.Professor");
            /*
            DropForeignKey("dbo.Topico", "IDProfessor", "dbo.Professor");
            DropForeignKey("dbo.Disciplina", "IDProfessor", "dbo.Professor");
            DropForeignKey("dbo.Aluno", "IDProfessor", "dbo.Professor");
            DropIndex("dbo.Topico", new[] { "IDProfessor" });
            DropIndex("dbo.Disciplina", new[] { "IDProfessor" });
            DropIndex("dbo.Aluno", new[] { "IDProfessor" });
            DropTable("dbo.Topico");
            DropTable("dbo.Disciplina");
            DropTable("dbo.Professor");
            DropTable("dbo.Aluno");
            */
        }
    }
}
