using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey;

/// <summary>
/// Obranca. Dava bodicky.
/// </summary>
internal sealed class DefenderHockeyPlayer : HockeyPlayer
{
    internal int Hits { get; set; }

    internal DefenderHockeyPlayer(string firstName, string lastName, DateOnly dateOfBirth, int hits) : base(firstName, lastName, dateOfBirth)
    {
        Hits = hits;
    }
}
