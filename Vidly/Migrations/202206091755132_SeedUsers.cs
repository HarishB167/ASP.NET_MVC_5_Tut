namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a5cefbe8-ab0b-4746-9c31-1804a00957d5', N'admin@vidly.com', 0, N'AN1aKpZ0FsLgIWT0NN6/Oikc0G3K6Iw65LjnpcCxrdJR1Oy1mcZRGDI0XVy4UhKhbQ==', N'787992ca-3523-4b0e-ad93-fdf1aeea705b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c484455b-27ce-4180-8a08-eb4517e49f2b', N'guest@vidly.com', 0, N'AFfi/0+Jdxp9y+3HUXqXxFzsOA4jGvPOTprzKPrNMEePpwXqOqHw+q8vnrIFE7q4AA==', N'e5ee0f28-2a9e-470b-ba96-6343b31e3117', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'15a49654-8a62-412f-8e19-a2586d1e6c10', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a5cefbe8-ab0b-4746-9c31-1804a00957d5', N'15a49654-8a62-412f-8e19-a2586d1e6c10')
");
        }
        
        public override void Down()
        {
        }
    }
}
