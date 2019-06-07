using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiskManagementTSD.Models;

namespace RiskManagementTSD.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Table");
        }
        [HttpGet]
        public ViewResult AddRisk()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddRisk(AddRisk addRisk)
        {
            // TODO: store response from guest
            /*Repository.AddResponse(guestResponse);*/
            return View("Thanks", addRisk);
            
        }
    }
}


/*Test, please ignore*/
/*Production brancssh*/
/*hello people */
/*Asia test */
/*comment test*/
