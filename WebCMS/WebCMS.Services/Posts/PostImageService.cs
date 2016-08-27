using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities;
using WebCMS.Entities.Models.Posts;

namespace WebCMS.Services.Posts
{
    public interface IPostImageService
    {
        void Add(int postId, int imageId, PostImageType postImageType);

        void Remove(int postId, PostImageType postImageType);
    }

    public class PostImageService : IPostImageService
    {
        #region Dependencies

        private readonly WebEntityModel _context;

        public PostImageService(WebEntityModel context)
        {
            _context = context;
        }

        #endregion Dependencies

        public void Add(int postId, int imageId, PostImageType postImageType)
        {
            var postImage = new PostImage
            {
                PostId = postId,
                PostImageType = postImageType,
                ImageId = imageId
            };

            _context.PostImages.Add(postImage);

            _context.SaveChanges();
        }

        public void Remove(int postId, PostImageType postImageType)
        {
            var postImages = _context.PostImages.Where(x => x.PostId == postId && x.PostImageType == postImageType);

            foreach (var postImage in postImages)
            {
                _context.PostImages.Remove(postImage);
            }

            _context.SaveChanges();
        }
    }
}
