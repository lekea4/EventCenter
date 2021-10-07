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
    public class LocationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<LocationController> _logger;
        private readonly IMapper _mapper;


        public LocationController(IUnitOfWork unitOfWork, ILogger<LocationController> logger, IMapper  mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
         
        [HttpGet]
        public async Task<IActionResult> GetLocationAsync()
        {
            try
            {
                var locations = await _unitOfWork.Locations.GetAll();
                var result = _mapper.Map<IList<LocationDTO>>(locations);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetLocationAsync)}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }
    }
}
