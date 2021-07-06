namespace LyVanTrieu_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanceledColumnToCoures : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coures", "IsCanceled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coures", "IsCanceled");
        }
    }
}
