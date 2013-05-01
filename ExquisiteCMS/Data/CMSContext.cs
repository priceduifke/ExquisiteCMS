using System.Data.Entity;
using ExquisiteCMS.Data.Entities;
using ExquisiteCMS.Areas.Webpage.Data.Entities;

namespace ExquisiteCMS.Data
{
    public class CMSContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ExquisiteCMS.Data.CMSContext>());

        public CMSContext() : base("name=CMSContext")
        {
        }

        public DbSet<Route> Routes { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
