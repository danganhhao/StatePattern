using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Hero
    {
        protected int hp;
        protected int BaseSpeed = 100;
        protected int BaseAccuracyRate = 1;
        protected int BaseCriticalRate = 100;

        private static HeroExtra[] allextras = new HeroExtra[3]
        {
            new HealthyHeroExtra(),
            new InjuredHeroExtra(),
            new NearlyDeadHeroExtra()
        };

        protected HeroExtra privateInfo = allextras[0];

        public int HP
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
                if (hp >= 80)
                    privateInfo = allextras[0];
                else if (hp >= 40)
                    privateInfo = allextras[1];
                else
                    privateInfo = allextras[2];
            }
        }
        public float Speed()
        {
            return BaseSpeed * privateInfo.GetSpeedRatio();
        }

        public float AccuracyRate()
        {
            return BaseAccuracyRate * privateInfo.GetAccuracyRatio();
        }

        public float CriticalRate()
        {
            return BaseCriticalRate * privateInfo.GetCriticalRatio();
        }
    }
   
}
