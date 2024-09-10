
    namespace PROG6212.Models
    {
        public class Claim
        {
            public int ClaimID { get; set; }
            public int LecturerID { get; set; }
        public string LecturerName { get; set; }
        public decimal HoursWorked { get; set; }
            public decimal RatePerHour { get; set; }
            public decimal TotalAmount { get; set; }
        public string SupportingDocumentFilePath { get; set; }
        public string Status { get; set; }
        }
    }