using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities.Models.Migrations;

namespace WebCMS.Entities.Models.Initializers
{
    internal class MigrateDatabaseToLatestVersion : MigrateDatabaseToLatestVersion<WebEntityModel, Configuration>
    {
        public override void InitializeDatabase(WebEntityModel context)
        {
            base.InitializeDatabase(context);
            this.Seed(context);
        }

        public virtual void Seed(WebEntityModel context)
        {

        }
    }
}
