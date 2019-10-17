using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer
{
    class Character
    {
        public Character()
        {
            Class = new List<Class>();
            Inventory = new List<Item>();
            SpellList = new List<Spell>();
        }
        public List<Class> Class;
        public List<Item> Inventory;
        public List<Spell> SpellList;
        public Background background;

    }
}
