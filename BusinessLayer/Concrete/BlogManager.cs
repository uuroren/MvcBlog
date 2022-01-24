using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
        }

        public void BlogAdd(Blog blog)
        {
            _blogdal.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogdal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogdal.Update(blog);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogdal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
           throw new NotImplementedException();
        }

        public List<Blog>GetBlogById(int id)
        {
            return _blogdal.GetListAll(x=> x.BlogId == id);
        }
        public List<Blog> GetList()
        {
            return _blogdal.GetListAll();
        }

        public List<Blog> GetList3Blog()
        {
            return _blogdal.GetListAll().Take(3).ToList(); 
        }
        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogdal.GetListAll(x => x.WriterId == id);
        }
    }
}
