using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> _repositoryComment = new Repository<Comment>();
    
        public List<Comment> CommentList()
        {
            return _repositoryComment.List();
        }

        public List<Comment> CommentByBlog(int id)
        {
            return _repositoryComment.List(x => x.BlogId == id);
        }

        public int CommentAdd(Comment comment)
        {
            if(comment.CommentText.Length <= 4 || comment.CommentText.Length >= 501 ||
                comment.UserName =="" || comment.Mail == "")
            {
                return -1;
            }
                return _repositoryComment.Insert(comment);
        }
    }
}
