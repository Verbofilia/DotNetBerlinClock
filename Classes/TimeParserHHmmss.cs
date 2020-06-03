using BerlinClock.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class TimeParserHHmmss : ITimeParser
    {
        private Regex timeRegex = new Regex(@"^(?:(?:([01]?\d|2[0-4]):)?([0-5]?\d):)?([0-5]?\d)$");
        public WideTime ParseTime(string aTime)
        {
            var match = timeRegex.Match(aTime);
            if (!match.Success)
            {
                throw new ArgumentException("Invalid time format");
            }

            return new WideTime
            {
                Hours = int.Parse(match.Groups[1].Value),
                Minutes = int.Parse(match.Groups[2].Value),
                Seconds = int.Parse(match.Groups[3].Value)
            };

        }
    }
}
