using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEnrollment.Models
{
    public static class MyExtensionMethods
    {
        public static string DisplayFirstName(this Enrollment myEnroll)
        {
            return myEnroll.FirstName;
        }

        public static IEnumerable<Enrollment> getEnrollmentmembersByLastName(this IEnumerable<Enrollment> enroll,string lastName)
        {
            foreach (Enrollment e in enroll)
            {
                if (e.LastName == lastName)
                    yield return e;
            }
        }
    }
}