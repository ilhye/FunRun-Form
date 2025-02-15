using Villasor_FunRun.Models;
using Microsoft.AspNetCore.Mvc;
using Villasor_FunRun.Models.Entities;
using Villasor_FunRun.Services;
using Microsoft.EntityFrameworkCore;

namespace Villasor_FunRun.Controllers
{
    public class ParticipantController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ParticipantController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult AddParticipant()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddParticipant(ParticipantViewModel viewModel)
        {
            await dbContext.Participants.AddAsync(new Participant
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Email = viewModel.Email,
                PNumber = viewModel.PNumber,
                distance = viewModel.distance
            });
            await dbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ParticipantList()
        {
            var participants = await dbContext.Participants.ToListAsync();

            return View(participants);
        }

    }
}
