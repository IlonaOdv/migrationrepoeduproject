using Eshop.BLL.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Eshop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatingController : ControllerBase
    {
        private readonly ILogger logger;

        public RatingController(ILogger logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RatingListDTO>>> GetAllAsync()
        {
            logger.LogInformation("All ratings to be retrieved.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var data = await repository.GetDataAsync();
            var data2 = repository.GetData();
            throw new NotImplementedException();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<RatingDetailDTO>> GetByIdAsync(int id)
        {
            logger.LogInformation("{id} to be retrieved.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var data = await repository.GetDataAsync();
            var data2 = repository.GetData();
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CreateRatingDTO data)
        {
            logger.LogInformation("Data to be created.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var data = await repository.GetDataAsync();
            var data2 = repository.GetData();
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(RatingDetailDTO data)
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