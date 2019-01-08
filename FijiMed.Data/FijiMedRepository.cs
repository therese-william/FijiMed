using FijiMed.Data.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FijiMed.Data
{
    public class FijiMedRepository : IFijiMedRepository
    {
        private readonly FijiMedContext _ctx;
        private readonly ILogger<FijiMedRepository> _logger;

        public FijiMedRepository(FijiMedContext ctx, ILogger<FijiMedRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public List<Patient> GetPatients()
        {
            try
            {
                return _ctx.Patients.ToList();
            }
            catch(Exception ex)
            {
                _logger.LogError($"Failed to retrieve patients: {ex}");
                return null;
            }
        }

        public List<User> GetUsers()
        {
            try
            {
                _logger.LogInformation("GetUsers() was called.");
                return _ctx.Users.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve users: {ex}");
                return null;
            }
        }

        public List<Doctor> GetDoctors()
        {
            try
            {
                return _ctx.Doctors.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve doctors: {ex}");
                return null;
            }
        }

        public bool SaveAll()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to save data: {ex}");
                return false;
            }
        }
    }
}
