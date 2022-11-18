using Eshop.BLL.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Eshop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducerController : ControllerBase
    {
        private readonly ILogger logger;

        public ProducerController(ILogger logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProducerListDTO>>> GetAllAsync()
        {
            logger.LogInformation("All producers to be retrieved.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var data = await repository.GetDataAsync();
            var data2 = repository.GetData();
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProducerDetailDTO>> GetByIdAsync(int id)
        {
            logger.LogInformation("{id} to be retrieved.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var data = await repository.GetDataAsync();
            var data2 = repository.GetData();
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CreateProducerDTO data)
        {
            logger.LogInformation("Data to be created.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var data = await repository.GetDataAsync();
            var data2 = repository.GetData();
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(ProducerDetailDTO data)
        {
            logger.LogInformation("Data to be updated.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var data = await repository.GetDataAsync();
            var data2 = repository.GetData();
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            logger.LogInformation("{id} to be deleted.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var data = await repository.GetDataAsync();
            var data2 = repository.GetData();
            throw new NotImplementedException();
        }
    }
}