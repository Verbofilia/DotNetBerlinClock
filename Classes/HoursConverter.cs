using BerlinClock.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public sealed class HoursConverter : BasePartialConverter
    {
        protected override int MinValue => 0;
        protected override int MaxValue => 59;

        protected override string ConvertValue(int source)
        {
            var builder = new StringBuilder();
            builder.Append(GetLine(source / 5, 4))
                .Append(Environment.NewLine)
                .Append(GetLine(source % 5, 4));
            return builder.ToString();
        }

        private string GetLine(int value, int count)
        {
            return String.Concat(Enumerable.Repeat(ColorsConstants.RedLamp, value)) 
                + string.Concat(Enumerable.Repeat(ColorsConstants.OffLamp, count - value));
        }

    }
}
