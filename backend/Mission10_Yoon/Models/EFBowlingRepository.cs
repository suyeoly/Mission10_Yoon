﻿
using Microsoft.EntityFrameworkCore;

namespace Mission10_Yoon.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingcontext;
        public EFBowlingRepository(BowlingLeagueContext temp) {
            _bowlingcontext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlingcontext.Bowlers;
        public IEnumerable<Team> Teams => _bowlingcontext.Teams;
    }
}
