namespace FijiMed.Data.Entities
{
    public class PatientAlergy
    {
        public int PatientAlergyId { get; set; }
        public int PatientId { get; set; }
        public string AlergyCondition { get; set; }
    }
}
