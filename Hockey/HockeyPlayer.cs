using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey
{
    /// <summary>
    /// Hokejovy hrac.
    /// </summary>
    internal class HockeyPlayer
    {
        internal string FirstName { get; }
        internal string LastName { get; }

        // Vek sa zistuje z datumu
        internal int Age
        {
            get 
            {
                DateOnly curDate = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                int dayDiff = curDate.DayNumber - _dateOfBirth.DayNumber;
                return dayDiff / 365;
            }
        }

        private readonly DateOnly _dateOfBirth;

        internal HockeyPlayer(string firstName, string lastName, DateOnly dateOfBirth) { 
            FirstName = firstName;
            LastName = lastName;
            _dateOfBirth = dateOfBirth;
        }
    }
}
