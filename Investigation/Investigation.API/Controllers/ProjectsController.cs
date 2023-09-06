using Investigation.API.Data;
using Investigation.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController:ControllerBase
    {
        private readonly DataContext _context;

        public ProjectsController(DataContext context)
        {


            _context = context;
        }

        // get por lista
        [HttpGet]
        public async Task<ActionResult> Get() { 
        
        return Ok(await
            _context.Projects.ToListAsync());
        
        
        }

        // get por parametro

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {

            var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id); 

            if(project == null)
            {

                 return NotFound();
            }

            return Ok(project);

        }

        [HttpPost]
        public async Task<ActionResult> Post(Project project)
        {

           _context.Add(project);
            await _context.SaveChangesAsync();
          return Ok(project);


        }


    }
}
