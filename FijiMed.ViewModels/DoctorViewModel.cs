using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FijiMed.ViewModels
{
	public class DoctorViewModel
	{
		public int DoctorId { get; set; }
		[Required]
		[MaxLength(10)]
		public string PrescriberNumber { get; set; }
		[Required]
		[MaxLength(10)]
		public string ProviderNumber { get; set; }
		[Required]
		public int UserId { get; set; }
		public string FullName { get; set; }

		public IEnumerable<ScriptViewModel> DoctorScripts { get; set; }
	}
}
