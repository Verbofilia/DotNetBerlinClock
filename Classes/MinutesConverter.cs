using BerlinClock.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public sealed class MinutesConverter : BasePartialConverter
    {
        protected override int MinValue => 0;
        protected override int MaxValue => 59;

        protected override string ConvertValue(int source)
        {
            var builder = new StringBuilder();
            var decrem = source;
            for (int i = 0; i < 4; i++)
            {
                builder.Append(GetQuarter(decrem, i==3));
                decrem -= 15;
            }
            builder.Append(Environment.NewLine);
            builder.Append(GetRemainder(source % 5));
            return builder.ToString();
        }

        private string GetQuarter(int count, bool isLast)
        {
            return (count < 5 ? ColorsConstants.OffLamp : ColorsConstants.YellowLamp)
                + (count < 10 ? ColorsConstants.OffLamp : ColorsConstants.YellowLamp)
                + (isLast? string.Empty: (count < 15 ? ColorsConstants.OffLamp : ColorsConstants.RedLamp));
        }
        private string GetRemainder(int count)
        {
            return String.Concat(Enumerable.Repeat(ColorsConstants.YellowLamp, count)) 
                + string.Concat(Enumerable.Repeat(ColorsConstants.OffLamp, 4 - count));
        }

    }
}
