using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog> _repoBlog = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return _repoBlog.List(); 
        }

        //public List<Blog> BlogById(int id)
        //{
        //    return repoBlog.List().Where(x => x.BlogId == id).ToList();
        //}

        public List<Blog> GetBlogById(int id)
        {
            return _repoBlog.List(x => x.BlogId == id);
        }

        public List<Blog> GetBlogByCategory(int id)
        {
            return _repoBlog.List(x => x.CategoryId == id);
        }

    }
}
