using NUnit.Framework;

using SpaceDefender.Core;


[TestFixture]
public sealed class ScoreCalculatorTests
{
    private ScoreCalculator calc;
    [SetUp]
    public void SetUp() => calc = new ScoreCalculator();
    [Test]
    public void Calculate_WithZeroKills_ReturnsZero()
    {
        int score = calc.Calculate(0, 0);

        Assert.AreEqual(0, score);
    }

    [Test]
    public void ApplyCombo_With3Kills_IncreasesMultiplier()
    {
        calc.ApplyCombo(3);

        Assert.Greater(calc.Multiplier, 1);
    }

    [Test]
    public void ResetMultiplier_AfterCombo_SetsMultiplierToOne()
    {
        calc.ApplyCombo(3);
        calc.ResetMultiplier();

        Assert.AreEqual(1, calc.Multiplier);
    }

    [Test]
    public void Calculate_AfterComboAndReset_UsesBaseMultiplier()
    {
        calc.ApplyCombo(3);
        calc.ResetMultiplier();

        int score = calc.Calculate(2, 0);

        Assert.AreEqual(2 * 10, score);
    }
}