using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    public class Member
    {
        public string MemberID{get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public  string Gender { get; set; }
        public  string HIC { get; set; }
        public int Age { get; set; }
        public void getAge()
        {
            try
            {

                DateTime dateOfBirth = Convert.ToDateTime(this.DateOfBirth);
                if (dateOfBirth > DateTime.Now)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    Age = (DateTime.Now.Subtract(dateOfBirth).Days) / 365;
                }
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message);
            }
           
            
        }





    }
}
