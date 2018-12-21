using System;
using System.Collections.Generic;
using System.Text;

namespace FijiMed.Data.Entities
{
    public class ScriptMedicine
    {
        public int ScriptMedicineId { get; set; }
        public int ScriptId { get; set; }
        public int MedicineId { get; set; }
        public int Repeats { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Directions { get; set; }
    }
}
