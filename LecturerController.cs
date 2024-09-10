using Microsoft.AspNetCore.Mvc;
using PROG6212.Models;

namespace PROG6212.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitClaim(Claim model, IFormFile supportingDocument)
        {
            // Placeholder for submission logic
            return RedirectToAction("ClaimsDashboard");
        }

        public IActionResult ClaimsDashboard()
        {
            // Placeholder for fetching claims
            var model = new ClaimsDashboardViewModel
            {
                Claims = new List<Claim> // Dummy data
                {
                    new Claim { ClaimID = 1, Status = "Pending" },
                    new Claim { ClaimID = 2, Status = "Approved" }
                }
            };
            return View(model);
        }
    }
}