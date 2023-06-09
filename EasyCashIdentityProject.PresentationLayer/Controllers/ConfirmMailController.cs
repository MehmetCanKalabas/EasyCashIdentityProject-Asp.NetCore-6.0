using EasyCashIdentityProject.EntityLayer.Concrete;
using EasyCashIdentityProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
        public ConfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
		public IActionResult Index()
		{
			var value = TempData["Mail"];
            ViewBag.v = value;
            //model.Mail = value.ToString();
			return View();
		}

        [HttpPost]
        public async Task<IActionResult> Index(ConfirmMailViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Mail);
            if (user.ConfirmCode == model.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","MyProfile");
            }
            return View();
        }
    }
}
