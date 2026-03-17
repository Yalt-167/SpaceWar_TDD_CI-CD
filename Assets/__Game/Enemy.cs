namespace SpaceDefender.Core
{
    public class Enemy
    {
        public int Health { get; private set; } = 100;
        private readonly int reward;
        public bool IsAlive { get; private set; } = true;

        public Enemy(int reward_)
        {
            reward = reward_;
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

        public int GetReward() => IsAlive ? reward : 0;
    } 
}