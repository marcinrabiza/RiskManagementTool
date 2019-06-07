using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiskManagementTSD.Models;

using Microsoft.AspNetCore.Mvc;
namespace RiskManagementTSD.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Table");
        }
        
        public ViewResult AddRisk()
        {
            return View();
        }
   
    }
}

/*Test, please ignore*/
/*Production brancssh*/
/*hello people */
/*Asia test */
/*comment test*/
