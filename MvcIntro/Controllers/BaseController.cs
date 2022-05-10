using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcIntro.Models.CustomUser;

namespace MvcIntro.Controllers
{
    public class BaseController : Controller
    {
        protected virtual new CustomUser User
        {
            get { return HttpContext.User as CustomUser; }
        }
    }
}