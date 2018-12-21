using System;
using System.Collections.Generic;

namespace FijiMed.Data.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IHI { get; set; }
        public bool IsCurrent { get; set; }
        public string MedicareCardNo { get; set; }
        public int MedicareCardValidToMonth { get; set; }
        public int MedicareCardValidToYear { get; set; }
        public string Title { get; set; }
        public string Sex { get; set; }
        public string CardFirstName { get; set; }
        public string CardLastName { get; set; }
        public bool IsMedicareEnquiry { get; set; }
        public string AddressStreet { get; set; }
        public string Suburb{ get; set; }
        public string Postcode { get; set; }
        public DateTime DOB { get; set; }
        public bool IsConcession { get; set; }
        public string ConcessionType { get; set; }
        public string ConcessionNumber { get; set; }
        public int ConcessionValidToMonth { get; set; }
        public int ConcessionValidToYear { get; set; }
        public string ConcessionReportType { get; set; }
        public string ConcessionTypeNo { get; set; }
        public string SafetyNetEntitlementNo { get; set; }
        public string PhoneNo { get; set; }
        public bool IsMyHRConsent { get; set; }
        public bool IseRxConsent { get; set; }
        public bool IsCTGRegistered { get; set; }
        public bool IsFamilyIncl { get; set; }
        public string Bag { get; set; }
        public string DiscountingPref { get; set; }
        public ICollection<PatientNote> PatientNotes { get; set; }
        public ICollection<Script> PatientScripts { get; set; }
        public ICollection<PatientAlergy> PatientAlergies { get; set; }
    }
}
