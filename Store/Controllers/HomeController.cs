using Microsoft.AspNetCore.Mvc;
using Store.CURD_DB;
using Store.Models;
using Store.Models.DB;
using Store.ViewModels;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataHelper<Categorie> dataHelper;
        private readonly AppDbContext appDbContext;

        //public readonly AppDbContext AppDbContext;

        public HomeController(IDataHelper<Categorie> dataHelper, AppDbContext appDbContext)
        {
            this.dataHelper = dataHelper;
            this.appDbContext = appDbContext;
            // AppDbContext = appDbContext;
        }

        

        public IActionResult Index()
        {
            HomeViewModels homeViewModels = new HomeViewModels(appDbContext);
              return View(homeViewModels);


        }
        public IActionResult Login()
        {
            
            return View();


        }/*
        [HttpPost]

        public IActionResult Login()
        {

            return View();


        }
        */
    }
}
