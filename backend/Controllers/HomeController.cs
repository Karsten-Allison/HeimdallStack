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

        public List<WorkInstructionSet> GetWorkInstructions()
        {
            return context.WorkInstructionSets.Include(I => I.InstructionSet).ToList();

        }

        public List<string> GetAllWorkInstructions()
        {
            return context.WorkInstructionSets.Select(I => I.Title).ToList();
        }
    }
}
