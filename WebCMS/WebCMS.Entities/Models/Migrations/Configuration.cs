using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WebEntityModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebEntityModel context)
        {
            
        }
    }
}
