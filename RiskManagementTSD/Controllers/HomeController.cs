using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskManagementTSD.Models;
using RiskManagementTSD.Models.Context;

namespace RiskManagementTSD.Controllers
{
    public class HomeController : Controller
    {
        private readonly RiskDbContext _riskDbContext;

        public HomeController(RiskDbContext context)
        {
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
            var riskToDelete = _riskDbContext.AddRisk.Find(addRisk.Id);
            _riskDbContext.Remove(riskToDelete);
            _riskDbContext.SaveChanges();
            return View("SuccessDelete", addRisk);
        }

        public ActionResult EditRisk(int? id)
        {
            var risk = _riskDbContext.AddRisk.SingleOrDefault(r => r.Id == id);
            return View(risk);
        }


        [HttpPost]
        public ActionResult EditRisk(AddRisk risk)
        {
            if (ModelState.IsValid)
            {
                _riskDbContext.Entry(risk).State = EntityState.Modified;
                _riskDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(risk);
        }

        [HttpGet]
        public ViewResult Details(AddRisk risk)
        {
            var currentRisk = _riskDbContext.AddRisk.Find(risk.Id);
            return View("Details", currentRisk);
        }
    }
}


/*Test, please ignore*/
/*Production brancssh*/
/*hello people */
/*Asia test */
/*comment test*/
