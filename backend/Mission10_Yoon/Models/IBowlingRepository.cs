namespace Mission10_Yoon.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
    }
}
