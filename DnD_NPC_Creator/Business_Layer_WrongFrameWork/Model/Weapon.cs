using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    public enum WeaponType { sMelee, sRanged, mMelee, mRanged }
    class Weapon : Item
    {
        public Weapon()
        {
            Properties = new List<string>();
        }

        List<string> Properties;
        string Damege;
        string DamageType;
        WeaponType Type;
    }
}
