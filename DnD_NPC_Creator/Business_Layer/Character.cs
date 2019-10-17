using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer
{
    public class Character
    {
        public Character()
        {
            Class = new List<Class>();
            Inventory = new List<Item>();
            SpellList = new List<Spell>();
        }
        List<Class> Class;
        List<Item> Inventory;
        List<Spell> SpellList;
        Background Background;

    }
}
