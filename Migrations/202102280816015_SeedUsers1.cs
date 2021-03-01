namespace dbStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'139a2b4f-92c4-4676-9311-efef5fe95ef0', N'guest@gmail.com', 0, N'AHiTgQwWpkQmQv/FEQ+JlK6qnFCv497mJ1Dn5fQMKJ7Vw0tHZfenVRsyIeZKA2ed8Q==', N'72c6187a-9f85-49bb-900e-4c35df8301e3', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'160c1bb7-868b-41e5-9539-264ce92c96af', N'admin@gmail.com', 0, N'AFXpZrFc+weQKEU6OYE6vPyL6iKtEceCixguWs+8kYCUzVVQFb6bNs9PrUnMPo1OVg==', N'c5a7b0bc-d8ec-4cd3-93da-9f8361837995', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f9e1c804-e096-4d30-a31d-78c4f587f968', N'CanManageMovies')

INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'160c1bb7-868b-41e5-9539-264ce92c96af', N'f9e1c804-e096-4d30-a31d-78c4f587f968')
        ");
        }

        public override void Down()
        {
        }
    }
}
