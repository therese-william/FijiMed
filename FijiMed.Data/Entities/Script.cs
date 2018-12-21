using System;
using System.Collections.Generic;

namespace FijiMed.Data.Entities
{
    public class Script
    {
        public int ScriptId { get; set; }
        public int PatientId { get; set; }
        public DateTime ScriptDate { get; set; }
        public string ScriptType { get; set; }
        public int DoctorId { get; set; }
        public string HospitalProviderNumber { get; set; }
        public string ProviderNumber { get; set; }
        public Doctor ScriptDoctor { get; set; }
        public Patient ScriptPatient { get; set; }
        public ICollection<ScriptMedicine> ScriptMedicines { get; set; }
        public ICollection<ScriptWarning> ScriptWarnings { get; set; }
        public ICollection<ScriptNote> ScriptNotes { get; set; }
    }
}
