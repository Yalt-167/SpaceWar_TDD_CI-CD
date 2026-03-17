namespace SpaceDefender.Core
{
    public class ScoreCalculator
    {
        private const int BaseScorePerKill = 10;

        public int Multiplier { get; private set; } = 1;

        public int Calculate(int kills) => kills <= 0 ? 0 : kills * BaseScorePerKill * Multiplier;

        public void ApplyCombo(int kills)
        {
            if (kills >= 3)
            {
                Multiplier = 2;
            }
        }

        public void ResetMultiplier()
        {
            Multiplier = 1;
        }
    }
}