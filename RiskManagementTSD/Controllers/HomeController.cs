using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiskManagementTSD.Models;
using RiskManagementTSD.Models.Context;

namespace RiskManagementTSD.Controllers
{
    public class HomeController : Controller
    {
        private readonly RiskDbContext _riskDbContext;

        public HomeController(RiskDbContext context) {
            _riskDbContext = context;
        }

       public ViewResult Index()
        {
            var risks = _riskDbContext.AddRisk.ToList();
            return View("Table", risks);
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
            //Saving to db.
            _riskDbContext.AddRisk.Add(addRisk);
            _riskDbContext.SaveChanges();
            return View("Success", addRisk); 
        }
        [HttpPost]
        public ViewResult DeleteRisk(AddRisk addRisk)
        {
            _riskDbContext.AddRisk.Remove(addRisk);
            _riskDbContext.SaveChanges();
            return View("SuccessDelete", addRisk);
        }
    }
}


/*Test, please ignore*/
/*Production brancssh*/
/*hello people */
/*Asia test */
/*comment test*/
