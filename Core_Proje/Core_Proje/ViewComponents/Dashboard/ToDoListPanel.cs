using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ToDoListPanel:ViewComponent
    {
        private ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.TGetList();
            return View(values);
        }
    }
}
