using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class BerlinClockConverter:TimeConverter
    {
        public BerlinClockConverter():base(
            new TimeParserHHmmss(),
            new SecondsConverter(),
            new MinutesConverter(),
            new HoursConverter())
        { }
    }
}
