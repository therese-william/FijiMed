namespace FijiMed.Data.Entities
{
    public class ScriptWarningDetail
    {
        public int ScriptWarningDetailId { get; set; }
        public int ScriptWarningId { get; set; }
        public string LTD { get; set; }
        public string STG { get; set; }
        public string Warning { get; set; }
    }
}
