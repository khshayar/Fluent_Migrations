using FluentMigrator;
using Microsoft.EntityFrameworkCore;

[Migration(20249231551)]

public class _20249231551_CreatUserTable :Migration
{
    public override void Up()
    {
        Create.Table("Users")
            .WithColumn("Id").AsInt32().Identity().PrimaryKey()
            .WithColumn("FirstName").AsString(100).NotNullable()
            .WithColumn("LastName").AsString(100).NotNullable()
            .WithColumn("PhoneNumber").AsString("10").NotNullable();

    }

    public override void Down()
    {
        Delete.Table("Users");
    }
}