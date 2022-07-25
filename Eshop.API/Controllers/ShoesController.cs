﻿using Eshop.BLL.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoesController : ControllerBase
    {
        [HttpGet("listofofferedshoes")]
        public List<GoodsDTO> ListOfOfferedShoes() => throw new NotImplementedException();

        [HttpPost("addnewshoes")]
        public void AddNewShoes() => throw new NotImplementedException();

        [HttpPut("updateanalreadyaddedshoes")]
        public void UpdateAnAlreadyAddedShoes() => throw new NotImplementedException();

        [HttpDelete("deleteshoes")]
        public void DeleteShoes() => throw new NotImplementedException();
    }
}