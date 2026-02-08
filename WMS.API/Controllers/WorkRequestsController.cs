using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WMS.Application.DTOs;
using WMS.Application.Interfaces;
using WMS.Domain.Entities;

namespace WMS.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/work-requests")]
    public class WorkRequestsController : ControllerBase
    {
        private readonly IWorkRequestService _service;

        public WorkRequestsController(IWorkRequestService service)
        {
            this._service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWorkRequestDto dto)
        {
            var result = await _service.CreateAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
    }
}
