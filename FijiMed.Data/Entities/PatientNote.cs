using System;

namespace FijiMed.Data.Entities
{
    public class PatientNote
    {
        public int PatientNoteId { get; set; }
        public int PatientId { get; set; }
        public DateTime NoteDate { get; set; }
        public int UserId { get; set; }
        public string NoteText { get; set; }
    }
}
