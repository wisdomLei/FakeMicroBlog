using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPS.Models;
using System.Security.Claims;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using IPS.Service;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IPS.MVC.Controllers {
    public class AccountController : Controller {
        private readonly IAccountService _accountService;
        private readonly IVeriCodeService _veriCodeService;
        public AccountController(IAccountService accountService, IVeriCodeService veriCodeService) {
            _accountService = accountService;
            _veriCodeService = veriCodeService;
        }

        //public override void OnActionExecuting(ActionExecutingContext context) {
        //    base.OnActionExecuting(context);
        //    if (User.Identity.Name != "") {
        //        var customerId = Int32.Parse(User.Claims.FirstOrDefault(c => c.Type == "ID").Value);
        //        _customerId = customerId;
        //    }
        //}

        /// <summary>
        /// 个人中心
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Index() {
            return View();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPost, Authorize]
        public IActionResult Modify(object postMessage) {
            return View();
        }

        /// <summary>
        /// 注册界面
        /// </summary>
        /// <returns></returns>
        public IActionResult Register() {
            return View();
        }

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <returns></returns>
        /// 说明：前端使用ajax方法请求，返回json表示成功或失败
        [HttpPost]
        public async Task<IActionResult> SendVericode(string email) {
            var sendResult = await _veriCodeService.Send(email);
            return Json(new { sendResult.Result, sendResult.Message });
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register([Bind("Name,Email,Password,VeriCode")] Register register) {
            var result = _accountService.AddCustomer(ModelState.IsValid, register);
            if (result.Result) {
                return RedirectToAction("Login");
            }
            else {
                ModelState.AddModelError("", result.Message);
                return View();
            }

        }

        /// <summary>
        /// 登录界面
        /// </summary>
        /// <returns></returns>
        public IActionResult Login() {
            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login([Bind("")] Login login) {

            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Logout() {
            return View("Login");
        }

        private IActionResult PublicMethod(bool result, string trueView, string controller, string action, object routeObject) {
            if (result) {
                return View(trueView);
            }
            else {
                return RedirectToAction(action, controller, routeObject);
            }
        }
    }
}
