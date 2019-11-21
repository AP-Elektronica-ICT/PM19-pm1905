using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Model
{
    public class Stat
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
                return (int)Math.Floor((TotalStat - 10m) / 2);
            }
        }
    }
}
