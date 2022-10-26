using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistic : ViewComponent
    {
        Context C = new Context();
        
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = C.Skills.Count();
            ViewBag.V2 = C.Messages.Where(x=>x.Status==false).Count();
            ViewBag.v3= C.Messages.Where(x => x.Status == true).Count();
            ViewBag.v4 = C.Experiences.Count();

            return View();
        }
    }

}
