using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog
{
    public class MainVM
    {
        private IPostRepository _postRepo;

        public MainVM(IPostRepository postRepo)
        {
            this._postRepo = postRepo;
        }
    }
}
