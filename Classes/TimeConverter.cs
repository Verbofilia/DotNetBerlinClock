using BerlinClock.Classes;
using BerlinClock.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {

        private readonly ITimeParser _timeParser;
        private readonly IPartialConverter _secondsConverter;
        private readonly IPartialConverter _hoursConverter;
        private readonly IPartialConverter _minutesConverter;

        public TimeConverter(
            ITimeParser timeParser,
            IPartialConverter secondsConverter,
            IPartialConverter minutesConverter,
            IPartialConverter hourssConverter)
        {
            _timeParser = timeParser;
            _secondsConverter = secondsConverter;
            _minutesConverter = minutesConverter;
            _hoursConverter = hourssConverter;
        }

        public string convertTime(string aTime)
        {

            var wideTime = _timeParser.ParseTime(aTime);

            return new StringBuilder()
                .Append(_secondsConverter.Convert(wideTime.Seconds))
                .Append(Environment.NewLine)
                .Append(_hoursConverter.Convert(wideTime.Hours))
                .Append(Environment.NewLine)
                .Append(_minutesConverter.Convert(wideTime.Minutes))
                .ToString();
        }
    }
}
