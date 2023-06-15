using FilmsStoreMvc.Models.DTO;
using FilmsStoreMvc.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FilmsStoreMvc.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthentificationService authService;
        public UserAuthenticationController(IUserAuthentificationService authService)
        {
            this.authService = authService;
        }
        public async Task<IActionResult> Register()
        {


            var model = new RegistrationModel
            {
                Email = "heyareyouok@gmail.com",
                Username = "Walid",
                Name = "Walid",
                Password = "Admin@123",
                PasswordConfirm = "Admin@123",
                Role = "Admin"
            };
            //    // if you want to register with user , Change Role="User"
            var result = await authService.RegisterAsync(model);

            return Ok(result.Message);


        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await authService.LoginAsync(model);
            if (result.StatusCode == 1)
                return RedirectToAction("Index", "Home");
            else
            {
                TempData["msg"] = "Could not logged in..";
                return RedirectToAction(nameof(Login));
            }
        }

        public async Task<IActionResult> Logout()
        {
            await authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
