﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represent one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represent the matchup that tis team came 
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }       
    }
}
