using BLL.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class AdminController : Controller
    {
        //IUserService _userService;
        //public AdminController(IUserService userService)
        //{
        //    _userService = userService;
        //}
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost("add")]
        //public IActionResult Add(User user)
        //{
        //    var result = _userService.Add(user);
        //    if (result.Success == true)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}
