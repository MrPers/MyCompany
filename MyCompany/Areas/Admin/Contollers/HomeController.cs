using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Areas.Admin.Contollers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public ActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
