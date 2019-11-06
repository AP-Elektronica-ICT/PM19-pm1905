using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    class Stat
    {
        public Stat(string name)
        {
            Name = name;
            TotalStat = 0;
        }
        public string Name;
        public int TotalStat { get; set; }
        public int StatModifier
        {
            get
            {
                return (int)Math.Ceiling(((decimal)TotalStat - 10m) / 2);
            }
        }
    }
}
