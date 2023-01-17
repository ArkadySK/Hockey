using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey
{
    /// <summary>
    /// Utocnik. Striela goly :)
    /// </summary>
    internal sealed class ForwardHockeyPlayer : HockeyPlayer
    {
        internal int GoalsShot { get; set; }

        internal ForwardHockeyPlayer(string firstName, string lastName, DateOnly dateOfBirth, int goalsShot) : base(firstName, lastName, dateOfBirth)
        {
            GoalsShot = goalsShot;
        }
    }
}
