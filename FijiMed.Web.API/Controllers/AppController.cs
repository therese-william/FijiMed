using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FijiMed.Data;
using Microsoft.AspNetCore.Mvc;

namespace FijiMed.Web.API.Controllers
{
    public class AppController : Controller
    {
        private readonly IFijiMedRepository _repository;

        public AppController(IFijiMedRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Patients()
        {
            var results = _repository.GetPatients();
            return View(results);
        }

        public IActionResult Doctors()
        {
            var results = _repository.GetDoctors();
            return View(results);
        }

        public IActionResult Users()
        {
            var results = _repository.GetUsers();
            return View(results);
        }
    }
}