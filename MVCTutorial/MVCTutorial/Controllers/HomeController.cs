using Microsoft.AspNetCore.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<BlogPost> blogPosts = new List<BlogPost>();

            BlogPost blogPost1 = new BlogPost();
            blogPost1.Title = "Paşa Döner'de alım var!";
            blogPost1.SubTtitle = "Paşa Döner sahibi Yunus Emre Bey yazılımcı departmanına alım yapacağını duyurdu.";
            blogPost1.PostDate = DateTime.Now;

            BlogPost blogPost2 = new BlogPost();
            blogPost2.Title = "Köfteci Yusuf'ta alım var!";
            blogPost2.SubTtitle = "Köfteci Yusuf sahibi Sami Bey yazılımcı departmanına alım yapacağını duyurdu.";
            blogPost2.PostDate = DateTime.Now;

            BlogPost blogPost3 = new BlogPost();
            blogPost3.Title = "Tavuk Dünyası'nda alım var!";
            blogPost3.SubTtitle = "Yavuk Dünyası sahibi Abdullah Bey yazılımcı departmanına alım yapacağını duyurdu.";
            blogPost3.PostDate = DateTime.Now;

            blogPosts.Add(blogPost1);
            blogPosts.Add(blogPost2);
            blogPosts.Add(blogPost3);

            return View(blogPosts);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Post()
        {
            return View();
        }
        public string GetName()
        {
            return "Mehmet Bayer";
        }
    }
}
