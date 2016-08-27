using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities;
using WebCMS.Entities.Models.PageBuilder;
using WebCMS.Services.Shared;

namespace WebCMS.Services.PageBuilder
{
    public interface IPageComponentTypeService
    {
        IEnumerable<PageComponentType> Get();

        PageComponentType Get(int pageComponentTypeId);

        void Add(int pageSectionId, string containerElementId, string elementBody);
    }

    public class PageComponentTypeService : IPageComponentTypeService
    {
        #region Dependencies

        private readonly WebEntityModel _context;

        public PageComponentTypeService(WebEntityModel context)
        {
            _context = context;
        }

        #endregion Dependencies

        public IEnumerable<PageComponentType> Get()
        {
            var results = _context.PageComponentTypes.OrderBy(x => x.PageComponentTypeName).ThenBy(x => x.PageComponentTypeId);

            return results;
        }

        public PageComponentType Get(int pageComponentTypeId)
        {
            var result = _context.PageComponentTypes.SingleOrDefault(x => x.PageComponentTypeId == pageComponentTypeId);

            return result;
        }

        public void Add(int pageSectionId, string containerElementId, string elementBody)
        {
            var pageSection = _context.PageSections.SingleOrDefault(x => x.PageSectionId == pageSectionId);

            if (pageSection == null)
                return;

            var document = new Document(pageSection.PageSectionBody);

            document.AddElement(containerElementId, elementBody);

            pageSection.PageSectionBody = document.OuterHtml;

            _context.SaveChanges();
        }
    }
}
