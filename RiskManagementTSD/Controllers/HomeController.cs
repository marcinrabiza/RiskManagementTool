using System.Linq;
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
            //var riskToDelete = _riskDbContext.AddRisk.Find(addRisk);
            _riskDbContext.AddRisk.Remove(addRisk);
            _riskDbContext.SaveChanges();
            return View("SuccessDelete", addRisk);
        }

        [HttpPost]
        public async Task<IActionResult> EditRisk(int riskId)
        {
            var riskToUpdate = _riskDbContext.AddRisk.Find(riskId);

            if (await TryUpdateModelAsync<AddRisk>(riskToUpdate, "", r => r.Name, r => r.Description, r => r.Probability, r => r.Impact))
            {
                try
                {
                    await _riskDbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException) {
                    ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists, " +
                    "see your system administrator.");
                }
            }
            var allRisks = _riskDbContext.AddRisk.ToList();
            return View("Table", allRisks);

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
