using AutoMapper;
using EventCenter.Domain.DTOs;
using EventCenter.Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventCenterController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<EventCenterController> _logger;
        private readonly IMapper _mapper;


        public EventCenterController(IUnitOfWork unitOfWork, ILogger<EventCenterController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetEventCenterAsync()
        {
            try
            {
                var eventPlaces = await _unitOfWork.EventPlaces.GetAll();
                var result = _mapper.Map<IList<EventPlaceDTO>>(eventPlaces);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetEventCenterAsync)}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventCenterByIdAsync(int id)
        {
            try
            {
                var eventplaces = await _unitOfWork.EventPlaces.Get(q => q.Id == id, new List<string> { "Locations" });
                var result = _mapper.Map<IList<EventPlaceDTO>>(eventplaces);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetEventCenterByIdAsync)}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }











    }
}
