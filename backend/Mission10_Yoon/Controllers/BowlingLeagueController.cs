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
        public IEnumerable<Bowler> Get() 
        {
            var bowlerData = _bowlingRepository.Bowlers.ToArray();
                 
            return bowlerData;
        }
    }
}
