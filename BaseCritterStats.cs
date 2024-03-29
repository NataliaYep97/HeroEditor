﻿using MyWonderfullAdventureHeroEditor.Enums;
using MyWonderfullAdventureHeroEditor.Wardrobe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWonderfullAdventureHeroEditor
{
    public abstract class BaseCritterStats
    {
        #region Private Fields

        private HeroType _heroType = HeroType.Archer;
        private LiveStatus _liveStatus = LiveStatus.Idle;
        private WeaponType _weaponType = WeaponType.Nothing;
        private ArmorType _armorType = ArmorType.Nothing;

        #endregion

        #region Public Properties

        public string Name { get; set; }
        public string Description { get; set; }

        public HeroType Type
        {
            get { return GetCritterType(); }
            set { SetCritterType(value); }
        }

        public LiveStatus Status
        {
            get { return GetCritterStatus(); }
            set { SetCritterStatus(value); }
        }

        public WeaponType Weapon
        {
            get { return GetWeaponType(); }
            set { SetWeaponType(value); }
        }

        public ArmorType Armor
        {
            get { return GetArmorType(); }
            set { SetArmorType(value); }
        }

        public abstract int HealthPoints { get; set; }
        public abstract int MinimalAttackHit { get; }
        public abstract int MaximumAttackHit { get; }
        public abstract int ArmorPoints{get; }


        #endregion

        #region Protected Method

        protected virtual HeroType GetCritterType()
        {
            return _heroType;
        }
        protected virtual void SetCritterType(HeroType type)
        {
            _heroType = type;
        }

        protected virtual LiveStatus GetCritterStatus()
        {
            if (HealthPoints <= 0)
            {
                return LiveStatus.Dead;
            }
            return _liveStatus;
        }

        protected virtual void SetCritterStatus(LiveStatus status)
        {
            _liveStatus = status;
        }

        protected virtual WeaponType GetWeaponType()
        {
            return _weaponType;
        }
        protected virtual void SetWeaponType(WeaponType weapon)
        {
            _weaponType = Weapon;
        }


        protected virtual ArmorType GetArmorType()
        {
            return _armorType;
        }
        protected virtual void SetArmorType(ArmorType armor)
        {
            _armorType = Armor;
        }

        #endregion

    }
}

