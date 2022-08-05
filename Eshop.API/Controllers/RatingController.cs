﻿using Eshop.BLL.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatingController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RatingListDTO>>> GetAllAsync() => throw new NotImplementedException();

        [HttpGet("{id}")]
        public async Task<ActionResult<RatingDetailDTO>> GetByIdAsync() => throw new NotImplementedException();

        [HttpPost]
        public async Task<IActionResult> AddAsync() => throw new NotImplementedException();

        [HttpPut]
        public async Task<IActionResult> UpdateAsync() => throw new NotImplementedException();

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id) => throw new NotImplementedException();
    }
}