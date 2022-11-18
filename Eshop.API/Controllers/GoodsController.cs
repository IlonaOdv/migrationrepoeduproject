using Eshop.BLL.DTOs;
using Eshop.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Eshop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoodsController : ControllerBase
    {
        // create Repository that return data (bogus)

        private readonly ILogger logger;

        public GoodsController(ILogger logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GoodsListDTO>>> GetAllAsync()
        {
            logger.LogInformation("All goods to be retrieved.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var dataFakeRepository = repository.GetDataAsync();

            throw new NotImplementedException();
        } 
            

        [HttpGet("{id}")]
        public async Task<ActionResult<GoodsDetailDTO>> GetByIdAsync(int id)
        {
            logger.LogInformation("{id} to be retrieved.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var dataFakeRepository = repository.GetDataById();

            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CreateGoodsDTO data)
        {
            logger.LogInformation("Data to be created.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var dataFakeRepository = repository.CreateData();

            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(GoodsDetailDTO data)
        {
            logger.LogInformation("Data to be updated.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var dataFakeRepository = repository.UpdateData();

            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            logger.LogInformation("{id} to be deleted.",
                DateTime.UtcNow.ToLongTimeString());

            var repository = new FakeRepository();
            var dataFakeRepository = repository.DeleteDataById();

            throw new NotImplementedException();
        }
    }
}