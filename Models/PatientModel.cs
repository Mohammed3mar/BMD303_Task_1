using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http.Results;

namespace Web_API_Demo.Models
{
    /// <summary>
    /// Represents one specific Patient !
    /// </summary>
    public class PatientModel
    {
        /// <summary>
        /// ID from SQL !
        /// </summary>
        public int ID { get; set; } = 0;
        /// <summary>
        /// Patients Name
        /// </summary>
        [Required]
        public string Name { get; set; } = "";

        public static explicit operator PatientModel(NotFoundResult v)
        {
            throw new NotImplementedException();
        }
    }
}
