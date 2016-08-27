using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities;
using WebCMS.Entities.Models.PageBuilder;

namespace WebCMS.Services.PageBuilder
{
    public interface IPageSectionTypeService
    {
        IEnumerable<PageSectionType> Get();
    }

    public class PageSectionTypeService : IPageSectionTypeService
    {
        #region Dependencies

        private readonly WebEntityModel _context;

        public PageSectionTypeService(WebEntityModel context)
        {
            _context = context;
        }

        #endregion Dependencies

        public IEnumerable<PageSectionType> Get()
        {
            var results = _context.PageSectionTypes.OrderBy(x => x.PageSectionTypeId);

            return results;
        }
    }
}
