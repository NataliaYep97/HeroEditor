using MyWonderfullAdventureHeroEditor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWonderfullAdventureHeroEditor.Wardrobe
{
    /// <summary>
    /// Части тела, на которые можно надеть оружие или броню
    /// </summary>
    public abstract class Equipment : BaseCritterStats
    {
        public abstract BodyParts Part { get; }
        public abstract void TakeWeaponsAndArmors(WeaponType weapon, ArmorType armor);
    }

    public enum BodyParts
    {
        Head,
        Torso,
        RightHand,
        LeftHand,
        Legs
    }
}
