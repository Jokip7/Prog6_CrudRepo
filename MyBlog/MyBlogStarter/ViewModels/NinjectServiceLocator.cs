using MyBlogStarter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogStarter.ViewModels
{
    public class NinjectServiceLocator
    {
        public MainViewModel Main
        {
            get
            {
                return new MainViewModel(new DummyBlogRepository());
            }
        }
    }
}
