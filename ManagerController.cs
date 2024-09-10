using Microsoft.AspNetCore.Mvc;
using PROG6212.Models;

public class ManagerController : Controller
{
    public IActionResult FinalApproval()
    {
        // Ensure this method returns the correct view
        var model = new FinalApprovalViewModel
        {
            Claims = new List<Claim>
            {
                new Claim { ClaimID = 1, LecturerName = "John Doe", Status = "Pending" },
                new Claim { ClaimID = 2, LecturerName = "Jane Smith", Status = "Approved" }
            }
        };
        return View(model);
    }

    public IActionResult ApproveClaim(int id)
    {
        // Implement approval logic here
        return RedirectToAction("FinalApproval");
    }

    public IActionResult RejectClaim(int id)
    {
        // Implement rejection logic here
        return RedirectToAction("FinalApproval");
    }
}