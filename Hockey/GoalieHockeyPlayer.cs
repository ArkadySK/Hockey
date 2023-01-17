using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey;

/// <summary>
/// Brankar. Zaznamenava sa pocet vyhranych zapasov.
/// </summary>
internal class GoalieHockeyPlayer : HockeyPlayer
{
    internal int GamesWon { get; set; }
    internal GoalieHockeyPlayer(string firstName, string lastName, DateOnly dateOfBirth, int gamesWon) : base(firstName, lastName, dateOfBirth)
    {
        GamesWon = gamesWon;
    }
}
