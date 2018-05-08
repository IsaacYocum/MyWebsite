namespace MyWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseAcronym = c.String(nullable: false, maxLength: 4),
                        CourseNum = c.String(nullable: false, maxLength: 4),
                        CourseDescription = c.String(nullable: false, maxLength: 255),
                        CourseYear_CourseYearId = c.Int(nullable: false),
                        Term_TermId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.CourseYears", t => t.CourseYear_CourseYearId, cascadeDelete: true)
                .ForeignKey("dbo.Terms", t => t.Term_TermId, cascadeDelete: true)
                .Index(t => t.CourseYear_CourseYearId)
                .Index(t => t.Term_TermId);
            
            CreateTable(
                "dbo.CourseYears",
                c => new
                    {
                        CourseYearId = c.Int(nullable: false, identity: true),
                        Year = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.CourseYearId);
            
            CreateTable(
                "dbo.Terms",
                c => new
                    {
                        TermId = c.Int(nullable: false, identity: true),
                        TermName = c.String(nullable: false, maxLength: 6),
                    })
                .PrimaryKey(t => t.TermId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Term_TermId", "dbo.Terms");
            DropForeignKey("dbo.Courses", "CourseYear_CourseYearId", "dbo.CourseYears");
            DropIndex("dbo.Courses", new[] { "Term_TermId" });
            DropIndex("dbo.Courses", new[] { "CourseYear_CourseYearId" });
            DropTable("dbo.Terms");
            DropTable("dbo.CourseYears");
            DropTable("dbo.Courses");
        }
    }
}
