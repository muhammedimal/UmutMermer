using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.DtoLAyer.Dtos.LoginDto;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginDto loginDto)
        {
           if (ModelState.IsValid)
            {

                var result=await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password ,false,false);
                if (result.Succeeded)
                {

                    return RedirectToAction("AdminProductPage", "Product");
                    
                }
                return View();
            }
            return View();
        }
    }
}
