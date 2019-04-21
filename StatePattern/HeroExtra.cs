namespace StatePattern
{
    public abstract class HeroExtra
    {
        protected float speed = 0;
        protected float accuracy = 0;
        protected float critical = 0;
        public virtual float GetSpeedRatio()
        {
            return speed;
        }

        public virtual float GetAccuracyRatio()
        {
            return accuracy;
        }
        public virtual float GetCriticalRatio()
        {
            return critical;
        }
    }

    public class HealthyHeroExtra: HeroExtra
    {
        private float speed = 1f;
        private float accuracy = 0.9f;
        private float critical = 0.3f;

        public override float GetSpeedRatio()
        {
            return speed;
        }

        public override float GetAccuracyRatio()
        {
            return accuracy;
        }

        public override float GetCriticalRatio()
        {
            return critical;
        }     
    }

    public class InjuredHeroExtra : HeroExtra
    {
        private float speed = 0.6f;
        private float accuracy = 0.6f;
        private float critical = 0.6f;

        public override float GetSpeedRatio()
        {
            return speed;
        }

        public override float GetAccuracyRatio()
        {
            return accuracy;
        }

        public override float GetCriticalRatio()
        {
            return critical;
        }
    }

    public class NearlyDeadHeroExtra : HeroExtra
    {
        private float speed = 0.2f;
        private float accuracy = 0.2f; 
        private float critical = 0.9f; 

        public override float GetSpeedRatio()
        {
            return speed;
        }

        public override float GetAccuracyRatio()
        {
            return accuracy;
        }

        public override float GetCriticalRatio()
        {
            return critical;
        }
    }
}