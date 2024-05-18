namespace ToDoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoItems", "Nume", c => c.String(nullable: false));
            AddColumn("dbo.ToDoItems", "Admis", c => c.Boolean(nullable: false));
            AddColumn("dbo.ToDoItems", "NumarLaboratoare", c => c.Int(nullable: false));
            AddColumn("dbo.ToDoItems", "Grupa", c => c.String(nullable: false));
            DropColumn("dbo.ToDoItems", "Title");
            DropColumn("dbo.ToDoItems", "Description");
            DropColumn("dbo.ToDoItems", "DueDate");
            DropColumn("dbo.ToDoItems", "IsCompleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ToDoItems", "IsCompleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ToDoItems", "DueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ToDoItems", "Description", c => c.String());
            AddColumn("dbo.ToDoItems", "Title", c => c.String(nullable: false));
            DropColumn("dbo.ToDoItems", "Grupa");
            DropColumn("dbo.ToDoItems", "NumarLaboratoare");
            DropColumn("dbo.ToDoItems", "Admis");
            DropColumn("dbo.ToDoItems", "Nume");
        }
    }
}
