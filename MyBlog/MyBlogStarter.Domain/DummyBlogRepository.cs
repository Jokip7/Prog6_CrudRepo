using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogStarter.Domain
{
    public class DummyBlogRepository : IBlogRepository
    {
        public List<Blog> blogs { get; set; }

        public DummyBlogRepository()
        {
            blogs = new List<Blog>();

            DateTime now = DateTime.Now;

            blogs.Add(new Blog
            {
                Id = 1,
                Author = "Chris",
                Content = "Hey hallo",
                TimeStamp = now,
                Title = "Dit is een test"
            });

            blogs.Add(new Blog
            {
                Id = 2,
                Author = "Chris",
                Content = "Doei",
                TimeStamp = now,
                Title = "Gedag"
            });

            blogs.Add(new Blog
            {
                Id = 3,
                Author = "Jeroen",
                Content = "On Plato",
                TimeStamp = now,
                Title = "Dioganes > Plato lol"
            });

            blogs.Add(new Blog
            {
                Id = 4,
                Author = "Matricia",
                Content = "Gloep gloep",
                TimeStamp = now,
                Title = "Important message"
            });

            blogs.Add(new Blog
            {
                Id = 5,
                Author = "Moderator",
                Content = "Al iemand nog een zo een stom bericht stuurt wordt hij of zij geband.",
                TimeStamp = now,
                Title = "Waarschuwing"
            });
        }

        public void Add(Blog blog)
        {
            blogs.Add(blog);
        }

        public void Delete(Blog blog)
        {
            blogs.Remove(blog);
        }

        public IEnumerable<Blog> GetAll()
        {
            return blogs;
        }
    }
}
