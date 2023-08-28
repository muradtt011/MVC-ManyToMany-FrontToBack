using Microsoft.AspNetCore.Mvc;
using PractiseMVCproject3.DAL;

namespace PractiseMVCproject3.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IActionResult Index()
        { 
            return View(_appDbContext.Features.ToList());
        }
    }
}
