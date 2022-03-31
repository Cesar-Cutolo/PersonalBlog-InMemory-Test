using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Context;

namespace PersonalBlog.Controllers
{
    public class TesteController : Controller
    {

        public IActionResult Index()
        {
            return View(BlogPostRepository.ListarBlogPost());
        }
    }
}
