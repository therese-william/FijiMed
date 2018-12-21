using System;

namespace FijiMed.Data.Entities
{
    public class Visit
    {
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime VisitDate { get; set; }
        public int ScriptId { get; set; }
        public string VisitNotes { get; set; }
    }
}
