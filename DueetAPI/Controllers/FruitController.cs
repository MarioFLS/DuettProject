using DueetAPI.Models;
using DueetAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DueetAPI.Controllers
{
    [Route("api/fruit")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly IDueetRepository _dueetRepository;

        public FruitController(IDueetRepository dueetRepository)
        {
            _dueetRepository = dueetRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fruit>>> FindAll()
        {
            var fruits = await _dueetRepository.FindAll();
            return Ok(fruits);
        }
    }
}
