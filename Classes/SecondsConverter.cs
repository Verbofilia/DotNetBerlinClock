using BerlinClock.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public sealed class SecondsConverter : BasePartialConverter
    {
        protected override int MinValue => 0;
        protected override int MaxValue => 59;

        protected override string ConvertValue(int source)
        {
            return source % 2 == 0 ? ColorsConstants.YellowLamp : ColorsConstants.OffLamp;
        }

    }
}
