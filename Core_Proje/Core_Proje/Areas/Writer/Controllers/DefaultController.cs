using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        private AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        
        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement=announcementManager.TGetByID(id);

            return View(announcement);
        }
    }
}
