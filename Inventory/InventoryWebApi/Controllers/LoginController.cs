using BusinessLogics.Bal;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
   
    public class LoginController : ControllerBase
    {
        private LoginBal bal;
        public LoginController(LoginBal bal)
        {
            this.bal = bal;
        }

        [HttpPost]
        public IActionResult Login(ApplicationUser applicationUser)
        {
            applicationUser= bal.Login(applicationUser);
            return Ok(applicationUser);
        }
    }
}
