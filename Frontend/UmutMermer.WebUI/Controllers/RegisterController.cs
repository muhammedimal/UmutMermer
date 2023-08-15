using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.DtoLAyer.Dtos.RegisterDto;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebUI.Controllers
{
    //ilerleyen zamanda kullanıcı kayıt istenirse kullanılacak bölüm
    public class RegisterController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Index(AddUserDto addUserDto)
        {
            var appUser = new AppUser()
            {
                Name = addUserDto.Name,


            };
            var result = await _userManager.CreateAsync(appUser /*AddUserDto.password*/);
            return View();
        }
    }
}
