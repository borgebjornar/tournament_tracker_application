using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {   
        /// <summary>
        /// Sets the place number.
        /// </summary>
        public int PlaceMNumber { get; set; }

        /// <summary>
        /// Sets the place name.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Sets the prize amount.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Sets the prize percentage.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
