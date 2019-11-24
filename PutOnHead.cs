using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWonderfullAdventureHeroEditor.Enums;

namespace MyWonderfullAdventureHeroEditor.Wardrobe
{
    public class PutOnHead : Equipment
    {

        #region Private Fields
        private int _armorPoints = 50;
        #endregion

        #region Public Properties

        public override BodyParts Part => BodyParts.Head;
        public override int HealthPoints { get; set; }

        public override int MinimalAttackHit { get; }
        public override int MaximumAttackHit { get; }

        public override void TakeWeaponsAndArmors(WeaponType weapon, ArmorType armor)
        {
            if (weapon != WeaponType.Nothing)
            {
                Console.WriteLine("You can't put a weapon on the head!");
            }

            switch (armor)
            {
                case ArmorType.HoodOfDefiance:
                    {
                        _armorPoints = _armorPoints + 30;
                    }
                    break;
                case ArmorType.IronHelmet:
                    {
                        _armorPoints = _armorPoints + 40;
                    }
                    break;
                default: throw new Exception();
            }
        }

        public override int ArmorPoints => _armorPoints;

        #endregion
    }
}
