using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        private UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetUserMessagesWithUserService();
            return View(values);
        }
    }
}
