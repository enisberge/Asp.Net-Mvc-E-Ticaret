using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Abc.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Rolleri
            if (!context.Roles.Any(i => i.Name == "admin"))//EĞER ADMİN İSMİNDE BİR ROL YOKSA
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))//EĞER USER İSMİNDE BİR ROL YOKSA
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);
            }
            if (!context.Users.Any(i => i.Name == "eberge"))//EĞER KULLANICI YOKSA
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "enis", Surname = "berge", UserName = "eberge", Email = "enisberge@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "admin");//şu anda bu kullanıcı hem admin hem user
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "sadikturan"))//EĞER KULLANICI YOKSA
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Sadık", Surname = "Turan", UserName = "sadikturan", Email = "sadikturan@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }

            //User
            base.Seed(context);
        }
    }
}