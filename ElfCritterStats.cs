using MyWonderfullAdventureHeroEditor.Wardrobe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWonderfullAdventureHeroEditor.Critters
{
    public sealed class ElfCritterStats : NPCCritterStats
    {
        #region Private Fields

        private int _healthPoints = 50;

        #endregion

        #region Public Properties

        public override int HealthPoints
        {
            get
            {
                return _healthPoints;
            }
            set
            {
                _healthPoints = value;
            }
        }

        public override int MinimalAttackHit { get; }
        public override int MaximumAttackHit { get; }

        public override int ArmorPoints { get; }

        private readonly int armorPoints;


        #endregion

        #region Protected Methods

        protected override HeroType GetCritterType()
        {
            return HeroType.Archer;
        }

        protected override void SetCritterType(HeroType type)
        {
            //TODO Возможно, что придется дополнить. Дома, как домашка
        }

        protected override LiveStatus GetCritterStatus()
        {
            if (HealthPoints > 100)

            {
                return LiveStatus.Idle;
            }

            return base.GetCritterStatus();
        }
        #endregion

        
    }
}
