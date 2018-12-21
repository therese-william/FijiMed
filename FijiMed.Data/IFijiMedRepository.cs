using System.Collections.Generic;
using FijiMed.Data.Entities;

namespace FijiMed.Data
{
    public interface IFijiMedRepository
    {
        IEnumerable<Doctor> GetDoctors();
        IEnumerable<Patient> GetPatients();
        IEnumerable<User> GetUsers();
        bool SaveAll();
    }
}