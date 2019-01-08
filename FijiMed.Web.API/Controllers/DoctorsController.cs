using FijiMed.Data;
using FijiMed.Data.Entities;
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

		public DoctorsController(IFijiMedRepository repository, ILogger<DoctorsController> logger)
		{
			_repository = repository;
			_logger = logger;
		}

		[HttpGet]
		public ActionResult<List<Doctor>> Get()
		{
			try
			{
				return _repository.GetDoctors();
			}
			catch (Exception ex)
			{
				_logger.LogError($"Failed to get doctors: {ex}");
				return BadRequest("Failed to get doctors");
			}
		}
	}
}
