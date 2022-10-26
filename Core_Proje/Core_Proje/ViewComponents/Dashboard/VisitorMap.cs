using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class VisitorMap:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
