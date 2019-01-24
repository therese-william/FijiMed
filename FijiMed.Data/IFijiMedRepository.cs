using System.Collections.Generic;
using FijiMed.Data.Entities;

namespace FijiMed.Data
{
    public interface IFijiMedRepository
    {
        List<Doctor> GetDoctors();
        List<Patient> GetPatients();
        List<User> GetUsers();
        bool SaveAll();
		Doctor GetDoctorById(int id);
		void AddEntity(object model);
	}
}