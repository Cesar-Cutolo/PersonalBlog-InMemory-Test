using Microsoft.EntityFrameworkCore;
using PersonalBlog.Extesions;

namespace PersonalBlog.Models
{
    public class BlogPostTeste
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
    }
}
