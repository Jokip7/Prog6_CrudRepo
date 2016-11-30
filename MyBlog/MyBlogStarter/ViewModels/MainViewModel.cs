using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlogStarter.Domain;

namespace MyBlogStarter.ViewModels
{
    public class MainViewModel
    {
        private IBlogRepository blogRepo { get; set; }

        public MainViewModel(IBlogRepository blogRepo)
        {
            this.blogRepo = blogRepo;
        }
    }
}
