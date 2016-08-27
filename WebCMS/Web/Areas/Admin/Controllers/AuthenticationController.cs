using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Areas.Admin.ViewModels.Authentication;
using WebCMS.Services.Authentication;

namespace Web.Areas.Admin.Controllers
{
    public class AuthenticationController : Controller
    {
        #region Dependencies

        private readonly ILoginService _loginService;
        private readonly IRegistrationService _registrationService;
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly ITokenService _tokenService;

        private const string IMG_DIR = "/Areas/Admin/Content/Media/Avatars";

        public AuthenticationController(ILoginService loginService, IRegistrationService registrationService, IUserService userService, IRoleService roleService, ITokenService tokenService)
        {
            _loginService = loginService;
            _registrationService = registrationService;
            _userService = userService;
            _roleService = roleService;
            _tokenService = tokenService;
        }

        #endregion Dependencies

        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("_Login", new LoginViewModel());
        }
	}
}