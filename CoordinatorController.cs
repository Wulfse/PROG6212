using Microsoft.AspNetCore.Mvc;
using PROG6212.Models;

namespace PROG6212.Controllers
{
    public class CoordinatorController : Controller
    {
        public IActionResult ReviewClaims(string statusFilter, DateTime? dateFilter)
        {
            // Placeholder for fetching claims based on filters
            var model = new ReviewClaimsViewModel
            {
                Claims = new List<Claim> // Dummy data
                {
                    new Claim { ClaimID = 1, LecturerName = "John Doe", Status = "Pending" },
                    new Claim { ClaimID = 2, LecturerName = "Jane Smith", Status = "Approved" }
                },
                StatusFilter = statusFilter,
                DateFilter = dateFilter
            };
            return View(model);
        }

        public IActionResult ApproveClaim(int id)
        {
            // Placeholder for approve logic
            return RedirectToAction("ReviewClaims");
        }

        public IActionResult RejectClaim(int id)
        {
            // Placeholder for reject logic
            return RedirectToAction("ReviewClaims");
        }
    }
}