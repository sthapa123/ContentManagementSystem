using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities;

namespace WebCMS.Services.Menu
{
    public interface IMenuItemService
    {
        int Create(int menuId, string linkText, string linkAction, string linkController, string linkArea);

        void Edit(int menuItemId, string linkText, string linkAction, string linkController, string linkArea);

        void Delete(int menuItemId);
    }

    public class MenuItemService : IMenuItemService
    {
        #region Dependencies

        private readonly WebEntityModel _context;

        public MenuItemService(WebEntityModel context)
        {
            _context = context;
        }

        #endregion Dependencies

        public int Create(int menuId, string linkText, string linkAction, string linkController, string linkArea)
        {
            var newMenuItem = new Entities.Models.Menu.MenuItem
            {
                MenuId = menuId,
                LinkText = linkText,
                LinkAction = linkAction,
                LinkController = linkController,
                LinkArea = linkArea
            };

            _context.MenuItems.Add(newMenuItem);

            _context.SaveChanges();

            return newMenuItem.MenuItemId;
        }

        public void Edit(int menuItemId, string linkText, string linkAction, string linkController, string linkArea)
        {
            var menuItem = _context.MenuItems.SingleOrDefault(x => x.MenuItemId == menuItemId);

            if (menuItem == null)
                return;

            menuItem.LinkText = linkText;
            menuItem.LinkAction = linkAction;
            menuItem.LinkController = linkController;
            menuItem.LinkArea = linkArea;

            _context.SaveChanges();
        }

        public void Delete(int menuItemId)
        {
            var menuItem = _context.MenuItems.SingleOrDefault(x => x.MenuItemId == menuItemId);

            if (menuItem == null)
                return;

            _context.MenuItems.Remove(menuItem);

            _context.SaveChanges();
        }
    }
}
