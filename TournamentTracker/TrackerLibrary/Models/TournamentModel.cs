using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// The unique identifier for the tournament.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Sets the tournament name.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Sets the entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Creates a list of the enteres teams in the GUI.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        ///  Creates a list of different prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Creates a list of rounds.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
