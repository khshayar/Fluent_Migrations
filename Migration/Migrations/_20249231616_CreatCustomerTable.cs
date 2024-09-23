using FluentMigrator;

namespace Migrations.Migrations;
[Migration(20249231616)]

public class _20249231616_CreatCustomerTable :Migration
{
    public override void Up()
    {
        Create.Table("Customers")
            .WithColumn("Id").AsInt32().Identity().PrimaryKey()
            .WithColumn("Address").AsString().NotNullable()
            .WithColumn("PostalCode").AsString().NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable()
            .ForeignKey("FK_Customers_Users", "Users", "Id");

        //Create.ForeignKey("UserId").FromTable("Users").ForeignColumn("Id");
    }

    public override void Down()
    {
        //Delete.ForeignKey();
        Delete.Table("Customers");
        
    }
}