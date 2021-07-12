using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Helper;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult ApplicationUserLogin()
        {
            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> ApplicationUserLogin(ApplicationUser applicationUser)
        {
            try
            {
                var data = await HttpHelper.Post<ApplicationUser>("https://localhost:44315/", "api/Login/Login", applicationUser);
                ViewBag.Name = data.IsAdmin;
                if (data.IsUsed)
                {
                    if (data.IsAdmin)
                    {
                        return RedirectToAction("Index", "ItemCategory");
                    }
                }
                return View("Login", data);
            }
            catch (Exception ex)
            {

                TempData["error"] = ex.Message;
                return RedirectToAction("ApplicationUserLogin", "Login");
            }
          
        }
    }
}

