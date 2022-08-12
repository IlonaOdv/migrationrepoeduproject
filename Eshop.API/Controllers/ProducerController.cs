using Eshop.BLL.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducerController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProducerListDTO>>> GetAllAsync() => throw new NotImplementedException();

        [HttpGet("{id}")]
        public async Task<ActionResult<ProducerDetailDTO>> GetByIdAsync(int id) => throw new NotImplementedException();

        [HttpPost]
        public async Task<IActionResult> AddAsync(CreateProducerDetailDTO data) => throw new NotImplementedException();

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(ProducerDetailDTO data) => throw new NotImplementedException();

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id) => throw new NotImplementedException();
    }
}