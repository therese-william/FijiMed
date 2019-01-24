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
	[Route("/api/doctors/{doctorid}/scripts")]
	public class DoctorScriptsController : Controller
	{
		private readonly IFijiMedRepository _repository;
		private readonly ILogger<DoctorsController> _logger;
		private readonly IMapper _mapper;
		public DoctorScriptsController(IFijiMedRepository repository, ILogger<DoctorsController> logger, IMapper mapper)
		{
			_repository = repository;
			_logger = logger;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult Get(int doctorid)
		{
			var doctor = _repository.GetDoctorById(doctorid);
			if (doctor != null)
			{
				return Ok(_mapper.Map<IEnumerable<Script>,IEnumerable<ScriptViewModel>>(doctor.DoctorScripts));
			}
			else
			{
				return NotFound();
			}
		}
	}
}
