using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public abstract class BasePartialConverter: IPartialConverter
    {
        protected abstract int MinValue { get; }
        protected abstract int MaxValue { get; }

        protected abstract string ConvertValue(int source);

        public string Convert(int source)
        {
            if (!Validate(source))
            {
                throw new ArgumentException($"Invalid time part value {source}");
            }
            return ConvertValue(source);
        }

        public bool Validate(int source)
        {
            return source >= MinValue && source <= MaxValue;
        }
    }
}
