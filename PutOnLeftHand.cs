using MyWonderfullAdventureHeroEditor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWonderfullAdventureHeroEditor.Wardrobe
{
    public class PutOnLeftHand : Equipment
    {
        #region Private Fields
        private int _minimalAttackHit = 0;
        private int _maximumAttackHit = 100;
        private int _armorPoints = 50;

        #endregion

        #region Public Properties

        public override BodyParts Part => BodyParts.LeftHand;
        public override int HealthPoints { get; set; }

        public override void TakeWeaponsAndArmors(WeaponType weapon, ArmorType armor)
        {
            #region Weapon's Type

            switch (weapon)
            {
                case WeaponType.HiddenBlade:
                    {
                        _minimalAttackHit = _minimalAttackHit + 30;
                        _maximumAttackHit = _maximumAttackHit + 30;
                    }
                    break;
                case WeaponType.FireSword:
                    {
                        _minimalAttackHit = _minimalAttackHit + 50;
                        _maximumAttackHit = _maximumAttackHit + 50;
                    }
                    break;
                case WeaponType.ShadowBlade:
                    {
                        _minimalAttackHit = _minimalAttackHit + 100;
                        _maximumAttackHit = _maximumAttackHit + 100;
                        _armorPoints = _armorPoints + 40;
                    }
                    break;
                case WeaponType.Frostmourne:
                    {
                        _minimalAttackHit = _minimalAttackHit + 80;
                        _maximumAttackHit = _maximumAttackHit + 80;
                        _armorPoints = _armorPoints + 30;
                    }
                    break;
                case WeaponType.CursedBlade:
                    {
                        _maximumAttackHit = _maximumAttackHit - 50;
                        _armorPoints = _armorPoints - 50;
                    }
                    break;
                case WeaponType.Arch:
                    {
                        _minimalAttackHit = _minimalAttackHit + 40;
                        _maximumAttackHit = _maximumAttackHit + 40;
                    }
                    break;
                case WeaponType.MagicStaff:
                    {
                        _minimalAttackHit = _minimalAttackHit + 70;
                        _maximumAttackHit = _maximumAttackHit + 70;
                        _armorPoints = _armorPoints + 20;
                    }
                    break;

                default: throw new Exception();
            }
            #endregion

            #region Armor's Type

            switch (armor)
            {
                case ArmorType.Vanguard:
                    {
                        _armorPoints = _armorPoints + 50;
                    }
                    break;
                case ArmorType.FireShield:
                    {
                        _armorPoints = _armorPoints + 40;
                    }
                    break;

                default: throw new Exception();
            }
            #endregion
        }

        public override int ArmorPoints => _armorPoints;
        public override int MinimalAttackHit => _minimalAttackHit;
        public override int MaximumAttackHit => _maximumAttackHit;

    }
    #endregion
}
