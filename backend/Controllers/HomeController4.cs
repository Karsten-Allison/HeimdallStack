/*

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using backend.data;
using backend.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController4 : ControllerBase
    {
        private readonly WorkInstructionDatabaseContext context;
        public HomeController4(WorkInstructionDatabaseContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WorkInstructionViewModel> Get()
        {
            return context.WorkInstructionSets.Include(I => I.InstructionSet).Select(I => new WorkInstructionViewModel
            {
                Title = I.Title,
                Description = I.Description,
                InstructionSet = I.InstructionSet,
            })
            .ToArray();
        }
    }
}

*/