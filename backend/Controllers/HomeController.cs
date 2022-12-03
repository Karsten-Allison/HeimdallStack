using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using backend.data;
using backend.ViewModel;

namespace backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly WorkInstructionDatabaseContext context;
        public HomeController(WorkInstructionDatabaseContext context)
        {
            this.context = context;

        }

        public IActionResult Index()
        {
            var WorkInstructionSet = this.context.WorkInstructionSets.Include(I => I.InstructionSet).Select(I => new WorkInstructionViewModel
            {
                Title = I.Title,
                Description = I.Description,
                InstructionSet = I.InstructionSet,

            });
            return View(WorkInstructionSet);
        }
    }
}
