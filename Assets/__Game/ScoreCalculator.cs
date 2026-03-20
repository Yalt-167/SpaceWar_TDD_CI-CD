namespace SpaceDefender.Core
{
    public sealed class ScoreCalculator
    {
        private const int BaseScorePerKill = 10;

        public int Multiplier { get; private set; } = 1;

        public int Calculate(int kills, int time) => kills * BaseScorePerKill * Multiplier;

        public void ApplyCombo(int comboCount) => Multiplier = comboCount > 1 ? comboCount - 1 : 1;

        public void ResetMultiplier() => Multiplier = 1;
    }
}