﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookify.Web.ViewComponents
{
    public class UserMessagePopup : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
