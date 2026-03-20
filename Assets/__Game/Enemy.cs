namespace SpaceDefender.Core
{
    public class Enemy
    {
        public int Health { get; private set; } = 100;
        private int PointValue { get; }
        public bool IsAlive { get; private set; } = true;
        public enum EnemyType { Basic, Fast, Tank, }
        public EnemyType Type{ get; private set; }

        public Enemy(int reward_)
        {
            PointValue = reward_;
        }

        public void TakeDamage(int amount)
        {
            if (!IsAlive)
                return;

            if (amount <= 0)
                return;

            Health -= amount;
            IsAlive = Health > 0;
            if (!IsAlive)
                Health = 0;
        }

        public int GetReward() => IsAlive ? PointValue : 0;
    } 
}