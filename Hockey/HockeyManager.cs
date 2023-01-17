using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey;

/// <summary>
/// Manazer hokejovych hracov.
/// </summary>
public class HockeyManager
{
    private readonly List<HockeyPlayer> _hockeyPlayers = new();

    public void AddNewForward(string firstName, string lastName, DateOnly dateOfBirth, int goalsShot)
    {
        ForwardHockeyPlayer forward = new(firstName, lastName, dateOfBirth, goalsShot);
        _hockeyPlayers.Add(forward);
    }

    public void AddNewDefender(string firstName, string lastName, DateOnly dateOfBirth, int hits)
    {
        DefenderHockeyPlayer defender = new(firstName, lastName, dateOfBirth, hits);
        _hockeyPlayers.Add(defender);
    }

    public void AddNewGoalie(string firstName, string lastName, DateOnly dateOfBirth, int gamesWon)
    {
        GoalieHockeyPlayer goalie = new(firstName, lastName, dateOfBirth, gamesWon);
        _hockeyPlayers.Add(goalie);
    }

    public void PrintNameAndAgeOfTheYoungestPlayer()
    {
        IEnumerable<HockeyPlayer> youngestPlayers = _hockeyPlayers.Where(
            player => player.Age == _hockeyPlayers.Min(p => p.Age)
        );

        foreach (var p in youngestPlayers)
        {
            Console.WriteLine($"The youngest player is: {p.FirstName} {p.LastName} - {p.Age}");

        }
    }
}
