using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Store.CURD_DB;
using Store.Models;
using Store.Models.DB;
using Store.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataHelper<Categorie> dataHelper;
        private readonly AppDbContext appDbContext;
        private readonly SignInManager<IdentityUser> SignInManager;
        public InputModel Input;

        //public readonly AppDbContext AppDbContext;

        public HomeController(IDataHelper<Categorie> dataHelper, AppDbContext appDbContext, SignInManager<IdentityUser> signInManager)
        {
            this.dataHelper = dataHelper;
            this.appDbContext = appDbContext;
            SignInManager = signInManager;
            // AppDbContext = appDbContext;
        }
        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "الأيميل")]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "كلمة السر")]
            public string Password { get; set; }

            [Display(Name = "تذكرني؟")]
            public bool RememberMe { get; set; }
        }

        public IActionResult Index()
        {
            HomeViewModels homeViewModels = new HomeViewModels(appDbContext);
            return View(homeViewModels);


        }
        public IActionResult Login()
        {

            return View();


        }
        [HttpPost]

        public async Task<IActionResult> Login(InputModel input_p)
        {
            //returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await SignInManager.PasswordSignInAsync(input_p.Email, input_p.Password, input_p.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {

                    return View("index");
                }
                return View();


            }
            else
            {
                ModelState.AddModelError(string.Empty, "كلمة السر او الأيميل غير صحيحين");
                return View();
            }

        }
    }
}
