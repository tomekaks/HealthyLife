﻿using HealthyLife.Application.Features.DailySums.Dtos;
using HealthyLife.Application.Features.DailySums.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/daily-sums")]
    [ApiController]
    public class DailySumsController : BaseController
    {
        private readonly IDailySumService _dailySumService;
        public DailySumsController(IHttpContextAccessor contextAccessor, IDailySumService dailySumService) : base(contextAccessor)
        {
            _dailySumService = dailySumService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DailySumDto>>> GetAllAsync()
        { 
            var dailySums = await _dailySumService.GetAllAsync(CurrentUserId);
            return Ok(dailySums);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DailySumDto>> GetByIdAsync(int id)
        {
            var dailySumDto = await _dailySumService.GetByIdAsync(id);
            return Ok(dailySumDto);
        }

        [HttpGet("by-date/{date}")]
        public async Task<ActionResult<DailySumDto>> GetByDateAsync(string date)
        {
            var dateOnly = DateOnly.Parse(date);

            var dailySumDto = await _dailySumService.GetByDateAsync(CurrentUserId, dateOnly);
            return Ok(dailySumDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateDailySumDto dailySumDto)
        {
            await _dailySumService.UpdateAsync(dailySumDto);
            return NoContent();
        }
    }
}
