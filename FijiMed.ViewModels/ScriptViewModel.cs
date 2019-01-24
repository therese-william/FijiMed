using System;

namespace FijiMed.ViewModels
{
	public class ScriptViewModel
	{
		public int ScriptId { get; set; }
		public int PatientId { get; set; }
		public DateTime ScriptDate { get; set; }
		public string ScriptType { get; set; }
		public int DoctorId { get; set; }
		public string HospitalProviderNumber { get; set; }
		public string ProviderNumber { get; set; }
	}
}