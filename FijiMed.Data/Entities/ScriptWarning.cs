using System.Collections.Generic;

namespace FijiMed.Data.Entities
{
    public class ScriptWarning
    {
        public int ScriptWarningId { get; set; }
        public int ScriptId { get; set; }
        public string WarningTitle { get; set; }
        public ICollection<ScriptWarningDetail> WarningDetails { get; set; }
    }
}
