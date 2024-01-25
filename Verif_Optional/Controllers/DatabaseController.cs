using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Verif_Optional.Data;
using Verif_Optional.Models;
using Verif_Optional.Models.Many_to_Many;
using Verif_Optional.Models.One_to_Many;

namespace Verif_Optional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly DataContext _DataContext;

        public DatabaseController(DataContext dataContext)
        {
            _DataContext = dataContext;
        }

        [HttpGet("model3")]
        public async Task<IActionResult> GetModel3()
        {
            return Ok(await _DataContext.Models3.ToListAsync());
        }

        [HttpGet("Autori")]
        public async Task<IActionResult> GetAutori()
        {
            return Ok(await _DataContext.Autori.ToListAsync());
        }

        [HttpPost("Autori")]
        public async Task<IActionResult> Create(Autori autori)
        {
            var newAutor = new Autori
            {

                Name = autori.Name,
                Age = autori.Age
            
            };

            await _DataContext.AddAsync(newAutor);
            await _DataContext.SaveChangesAsync();

            return Ok(newAutor);
        }

        [HttpPost("model3")]
        public async Task<IActionResult> Create(Model3 model3)
        {
            var newModel3 = new Model3
            {
                Name = model3.Name
            };

            await _DataContext.AddAsync(newModel3);
            await _DataContext.SaveChangesAsync();

            return Ok(newModel3);
        }


    }
}
