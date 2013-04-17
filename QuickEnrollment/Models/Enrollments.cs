using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace QuickEnrollment.Models
{
    public class Enrollments:IEnumerable<Enrollment>
    {
        public List<Enrollment> enrollments { get; set; }

        public IEnumerator<Enrollment> GetEnumerator(){
            return enrollments.GetEnumerator();
        }

         IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}