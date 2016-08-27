using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities;
using WebCMS.Entities.Models.Posts;

namespace WebCMS.Services.Posts
{
    public interface IPostCommentService
    {
        void Add(int userId, int postId, string commentBody);

        IEnumerable<PostComment> Get();
    }

    public class PostCommentService : IPostCommentService
    {
        #region Dependencies

        private readonly WebEntityModel _context;

        public PostCommentService(WebEntityModel context)
        {
            _context = context;
        }

        #endregion Dependencies

        public void Add(int userId, int postId, string commentBody)
        {
            var comment = new PostComment
            {
                UserId = userId,
                PostId = postId,
                CommentBody = commentBody,
                DateAdded = DateTime.Now
            };

            _context.PostComments.Add(comment);

            _context.SaveChanges();
        }

        public IEnumerable<PostComment> Get()
        {
            var comments = _context.PostComments.OrderBy(x => x.DateAdded);

            return comments;
        }
    }
}
