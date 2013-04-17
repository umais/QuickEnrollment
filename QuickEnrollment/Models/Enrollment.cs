using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEnrollment.Models
{
    public class Enrollment
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String DOB { get; set; }
        public String Gender { get; set; }
        public String PlanID { get; set; }
        public String PBP { get; set; }
        public String UniqueID { get; set; }
        public String MemberID { get; set; }
        public string RxId { get; set; }
        public String PremiumC { get; set; }
        public String PremiumD { get; set; }
        public String signatureDate { get; set; }
        public String RecieptDate { get; set; }
        public String ElectionType { get; set; }

    }
}