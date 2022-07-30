using Microsoft.AspNetCore.Mvc;
using Tech.Core.Concrete;
using Tech.Core.Services;

namespace Tech.Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly IService<Post> _services;

        public PostsController(IService<Post> services)
        {
            _services = services;
        }

        public  async Task<IActionResult> Index()
        {
            return View(await _services.GetAllAsync());
        }
    }
}
