using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        private ContactManager contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();

            return View(values);
        }
    }
}
