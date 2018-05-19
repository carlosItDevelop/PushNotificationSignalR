
using PushNotification.Contexto;
using System.Data.Entity.Migrations;

namespace PushNotification.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PushNotificationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PushNotificationContext context)
        {

        }
    }
}
