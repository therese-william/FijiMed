namespace FijiMed.Data.Entities
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        public string ReaderNo { get; set; }
        public string ItemDescription { get; set; }
        public int MedicineTypeId { get; set; }
        public int Volume { get; set; }
        public string Unit { get; set; }
        public MedicineType MedicineMedicineType { get; set; }
    }
}
