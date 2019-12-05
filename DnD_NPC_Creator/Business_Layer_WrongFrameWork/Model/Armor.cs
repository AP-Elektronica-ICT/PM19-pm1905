using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    public enum ArmorType { Light, Medium, Heavy, Shield }
    class Armor : Item
    {
        ArmorType Type;
        int AC;
        bool Disadvantage;
    }
}
