using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Yoon.Models;

namespace Mission10_Yoon.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingLeagueController(IBowlingRepository temp) {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var joinedData = from Bowlers in _bowlingRepository.Bowlers
                             join Teams in _bowlingRepository.Teams on Bowlers.TeamId equals Teams.TeamId
                             select new JoinedBowler
                             {
                                 BowlerMiddleInit = Bowlers.BowlerMiddleInit,
                                 BowlerAddress = Bowlers.BowlerAddress,
                                 BowlerCity = Bowlers.BowlerCity,
                                 BowlerID = Bowlers.BowlerId,
                                 BowlerLastName = Bowlers.BowlerLastName,
                                 BowlerFirstName = Bowlers.BowlerFirstName,
                                 BowlerState = Bowlers.BowlerState,
                                 BowlerZip = Bowlers.BowlerZip,
                                 BowlerPhoneNumber = Bowlers.BowlerPhoneNumber,
                                 TeamId = Bowlers.TeamId,
                                 TeamName = Teams.TeamName
                             };
            return joinedData.Where(data => data.TeamName == "Marlins" || data.TeamName == "Sharks").ToList();
        }
    }
}
