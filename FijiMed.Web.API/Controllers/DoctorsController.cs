using AutoMapper;
using FijiMed.Data;
using FijiMed.Data.Entities;
using FijiMed.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FijiMed.Web.API.Controllers
{
	[Route("api/[Controller]")]
	public class DoctorsController : ControllerBase
	{
		private readonly IFijiMedRepository _repository;
		private readonly ILogger<DoctorsController> _logger;
		private readonly IMapper _mapper;

		public DoctorsController(IFijiMedRepository repository, ILogger<DoctorsController> logger, IMapper mapper)
		{
			_repository = repository;
			_logger = logger;
			_mapper = mapper;
		}

		[HttpGet]
		public ActionResult<List<Doctor>> Get()
		{
			try
			{
				return Ok(_repository.GetDoctors());
			}
			catch (Exception ex)
			{
				_logger.LogError($"Failed to get doctors: {ex}");
				return BadRequest("Failed to get doctors");
			}
		}

		[HttpGet("{id:int}")]
		public ActionResult<DoctorViewModel> Get(int id)
		{
			try
			{
				var doctor = _repository.GetDoctorById(id);
				if (doctor != null)
				{
					return Ok(_mapper.Map<Doctor, DoctorViewModel>(doctor));
				}
				else
				{
					return NotFound();
				}
			}
			catch (Exception ex)
			{
				_logger.LogError($"Failed to get doctors: {ex}");
				return BadRequest("Failed to get doctors");
			}
		}

		[HttpPost]
		public IActionResult Post([FromBody]DoctorViewModel doctor)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var newDoctor = _mapper.Map<DoctorViewModel, Doctor>(doctor);
					_repository.AddEntity(newDoctor);
					if (_repository.SaveAll())
					{
						return Created($"/api/Doctors/{newDoctor.DoctorId}", _mapper.Map<Doctor, DoctorViewModel>(newDoctor));
					}
					else
					{
						return BadRequest("Failed to save doctor");
					}
				}
				else
				{
					return BadRequest(ModelState);
				}
			}
			catch (Exception ex)
			{
				_logger.LogError($"Failed to save doctor: {ex}");
				return BadRequest("Failed to save doctor");
			}
		}
	}
}
