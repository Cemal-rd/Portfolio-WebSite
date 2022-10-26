using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        private ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
        
    }
}
