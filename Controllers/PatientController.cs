using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Web_API_Demo.Models;
using System.Net;
using System.Net.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace Web_API_Demo.Controllers
{
    /// <summary>
    /// Here is All the Information !!!
    /// </summary>
    public class PatientController : ApiController
    {

        List<PatientModel> Patient = new List<PatientModel>();

        public PatientController()
        {
            Patient.Add(new PatientModel { ID = 1, Name = "Mohammed Hassan Ali" });
            Patient.Add(new PatientModel { ID = 2, Name = "Dina Sharwida" });
        }

        /// <summary>
        /// Gets a list of all Names of all Users !!!
        /// </summary>
        /// <returns>A list of all Names !</returns>

        //[Route("api/Patient/GetName/{userId:int}/{age:int}")]
        [Route("api/Patient/GetName")]
        [HttpGet]
        public List<string> GetName()
        {
            List<string> output = new List<string>();

            foreach (var p in Patient)
            {
                output.Add(p.Name);
            }
            return output;
        }

        /// <summary>
        /// Get all Patients !
        /// </summary>
        /// <returns></returns>
        // GET api/Patient
        public List<PatientModel> Get()
        {
            return Patient;
        }

        /// <summary>
        /// Get a specific Patient with ID !
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/Patient/5
        public PatientModel Get(int id)
        {
            return Patient.Where(x => x.ID == id).FirstOrDefault();
        }

        /// <summary>
        /// Add a Patient !
        /// </summary>
        /// <param name="val"></param>
        // POST: api/Patient
        public void post(PatientModel val)
        {
            Patient.Add(val);
        }

        /// <summary>
        /// Delete a Patient !
        /// </summary>
        /// <param name="id">ID od Patient to be deleted !</param>
        // Delete: api/Patient/5
        public void Delete(int id)
        {

        }

    }
}
