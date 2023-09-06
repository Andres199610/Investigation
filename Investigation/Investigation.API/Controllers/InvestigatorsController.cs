using Investigation.API.Data;
using Investigation.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("api/investigators")]
    public class InvestigatorsController:ControllerBase
    {
        private readonly DataContext _context;



        public InvestigatorsController(DataContext context)
        {


        _context = context;

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await _context.Investigators.ToListAsync());


        }

        [HttpPost]

        public async Task<IActionResult> Post(Investigator investigator)
        {
           _context.Add(investigator);
            await _context.SaveChangesAsync();

            return Ok(investigator);



        }

    }
}
