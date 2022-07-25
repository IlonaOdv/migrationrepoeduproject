using Eshop.BLL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothesController
    {
        [HttpGet("listofofferedclothes")]
        public List<GoodsDTO> ListOfOfferedClothes() => throw new NotImplementedException();

        [HttpPost("addnewclothes")]
        public void AddNewClothes() => throw new NotImplementedException();

        [HttpPut("updateanalreadyaddedclothes")]
        public void UpdateAnAlreadyAddedClothes() => throw new NotImplementedException();

        [HttpDelete("deleteclothes")]
        public void DeleteClothes() => throw new NotImplementedException();
    }
}