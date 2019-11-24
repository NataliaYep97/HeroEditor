using MyWonderfullAdventureHeroEditor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWonderfullAdventureHeroEditor.Wardrobe
{
    public class PutOnTorso : Equipment
    {

        #region Private Fields
        private int _armorPoints = 50;
        #endregion

        #region Public Properties

        public override BodyParts Part => BodyParts.Torso;
        public override int HealthPoints { get; set; }

        public override int MinimalAttackHit { get; }
        public override int MaximumAttackHit { get; }

        public override void TakeWeaponsAndArmors(WeaponType weapon, ArmorType armor)
        {
            if (weapon != WeaponType.Nothing)
            {
                Console.WriteLine("You can't put a weapon on the torso!");
            }

            switch (armor)
            {
                case ArmorType.AssaultCuirass:
                    {
                        _armorPoints = _armorPoints + 70;
                    }
                    break;
                case ArmorType.BladeMail:
                    {
                        _armorPoints = _armorPoints + 80;
                    }
                    break;
                default: throw new Exception();
            }
        }

        public override int ArmorPoints => _armorPoints;

        #endregion
    }
}
