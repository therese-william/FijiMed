using FijiMed.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FijiMed.Data
{
    public class FijiMedRepository : IFijiMedRepository
    {
        private readonly FijiMedContext _ctx;

        public FijiMedRepository(FijiMedContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Patient> GetPatients()
        {
            return _ctx.Patients.ToList();
        }

        public IEnumerable<User> GetUsers()
        {
            return _ctx.Users.ToList();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _ctx.Doctors.ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
