using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FijiMed.Data.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string PrescriberNumber { get; set; }
        [Required]
        public string ProviderNumber { get; set; }
        public int UserId { get; set; }
        public User DoctorUser { get; set; }
        public ICollection<Script> DoctorScripts { get; set; }
    }
}
