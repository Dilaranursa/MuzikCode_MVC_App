namespace MuziCodeWepApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MuziCodeWepApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MuziCodeWepApp.Models.MuzicCodeDBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;//okudum onaylıyorum veri kaybı olabilir diye


        }

        protected override void Seed(MuzicCodeDBModel context)
        {
            #region Manager Types

            //context.ManagersRol.AddOrUpdate(x => x.ID, new ManagerRole() { ID = 1, Name = "Admin", IsDeleted = false });
            //context.ManagersRol.AddOrUpdate(x => x.ID, new ManagerRole() { ID = 2, Name = "Moderatör", IsDeleted = false });

            #endregion

            #region Manager

            //context.Manager.AddOrUpdate(x => x.ID, new Manager() { ID = 1, Name = "Developer", Surname = "Developer", Mail = "dev@dev.com", ManagerRole_ID = 1, Password = "12345", IsActive = true, IsDeleted = false });

            #endregion


        }
    }
}
