using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogStarter.Domain
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAll();

        void Add(Blog blog);

        void Delete(Blog blog);
    }
}
