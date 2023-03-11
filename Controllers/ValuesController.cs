using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Demo.Controllers
{
    /// <summary>
    /// Value Controller
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get all values
        /// </summary>
        /// <returns></returns>
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get specific values
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Post values 
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Edit values 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete values 
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
