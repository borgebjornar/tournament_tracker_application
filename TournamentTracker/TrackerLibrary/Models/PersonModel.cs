using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Sets firstname.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Sets last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Sets email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Sets cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
