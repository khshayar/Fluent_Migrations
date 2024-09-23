using FluentMigrator;
using Microsoft.EntityFrameworkCore;

[Migration(20249231559)]
public class _20249231559_CreatEmployeTable:Migration
{
    public override void Up()
    {
        Create.Table("Staffs")
            .WithColumn("Id").AsInt32().Identity().ForeignKey()
            .WithColumn("PersonnelNumber").AsString(10).NotNullable()
            .WithColumn("StoreId").AsInt32().Nullable()
            .WithColumn("UserId").AsInt32().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("Staffs");
    }
}