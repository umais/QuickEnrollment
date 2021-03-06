﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using EnrollmentClassLibrary.Repositories;
using EnrollmentClassLibrary.Models;

namespace QuickEnrollment.Controllers
{
    public class EnrollmentsController : ApiController
    {
        //
        // GET: /Enrollment/
        ITransactionRepository r=EnrollmentRepository.getEnrollmentRepo();
        //public EnrollmentsController()
        //{
        //    System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(BaseTransaction),new Type[] {typeof(EnrollmentTransaction)});
        //}
        public List<BaseTransaction> getEnrollments()
        {
            return r.getAll();
        }

        public BaseTransaction getEnrollmentByID(string id)
        {
            return r.get(id);
        }

        [HttpPost]
        public void InsertTransaction([FromBody] EnrollmentTransaction newTrans)
        {
            r.Insert(newTrans);
        }
        
        [HttpPut]
        public void UpdateTransaction([FromBody] EnrollmentTransaction updatedTransaction)
        {
            r.Update(updatedTransaction);
        }

    }
}
