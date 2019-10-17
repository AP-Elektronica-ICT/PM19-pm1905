using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer
{
    class Stat
    {
        public string Name;
        public int TotalStat;
        public int StatModifier
        {
            get
            {
                return (int)Math.Ceiling(((decimal)TotalStat - 10m) / 2);
            }
        }
    }
}
