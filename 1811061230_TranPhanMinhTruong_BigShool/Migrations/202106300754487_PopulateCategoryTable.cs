namespace _1811061230_TranPhanMinhTruong_BigShool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categories(Id,Name) Values (1 , 'Development')");
            Sql("insert into Categories(Id,Name) Values (2 , 'Busioness')");
            Sql("insert into Categories(Id,Name) Values (3 , 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
