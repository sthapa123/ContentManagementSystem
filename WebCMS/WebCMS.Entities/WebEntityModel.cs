using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities.Models.Authentication;
using WebCMS.Entities.Models.Copy;
using WebCMS.Entities.Models.Generic;
using WebCMS.Entities.Models.Menu;
using WebCMS.Entities.Models.PageBuilder;
using WebCMS.Entities.Models.Posts;
using WebCMS.Entities.Models.Settings;

namespace WebCMS.Entities
{
    public class WebEntityModel : DbContext
    {
        public WebEntityModel() : base("name=WebEntityModel") { }
    
        #region Authentication Entities
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserToken> UserTokens { get; set; }
        #endregion Authentication Entities

        #region Post Entities

        public virtual DbSet<Post> Posts { get; set; }

        public virtual DbSet<PostCategory> PostCategories { get; set; }

        public virtual DbSet<PostImage> PostImages { get; set; }

        public virtual DbSet<PostComment> PostComments { get; set; }

        public virtual DbSet<PostRole> PostRoles { get; set; }

        #endregion Post Entities

        #region Generic Entities

        public virtual DbSet<Image> Images { get; set; }

        #endregion Generic Entities

        #region Copy Entities

        public virtual DbSet<Copy> CopySections { get; set; }

        #endregion Copy Entities

        #region Menu Entities

        public virtual DbSet<Menu> Menus { get; set; }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        #endregion Menu Entities

        #region Setting Entities

        public virtual DbSet<Setting> Settings { get; set; }

        #endregion Setting Entities

        #region Page Builder Entities

        public virtual DbSet<Page> Pages { get; set; }

        public virtual DbSet<PageSection> PageSections { get; set; }

        public virtual DbSet<PageSectionType> PageSectionTypes { get; set; }

        public virtual DbSet<PageComponentType> PageComponentTypes { get; set; }

        public virtual DbSet<PageRole> PageRoles { get; set; }

        #endregion Page Builder Entities
    }
}
