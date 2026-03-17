using NUnit.Framework;

using SpaceDefender.Core;

[TestFixture]
public class EnemyTests
{
    private Enemy enemy;
    [SetUp]
    public void SetUp() => enemy = new Enemy(50);

    [Test]
    public void TakeDamage_WhenKilled_SetsIsAliveToFalse()
    {
        enemy.TakeDamage(200);

        Assert.IsFalse(enemy.IsAlive);
    }

    [Test]
    public void GetReward_WhenAlreadyDead_ReturnsZero()
    {
        Enemy enemy = new Enemy(50);
        enemy.TakeDamage(100);

        int reward = enemy.GetReward();

        Assert.AreEqual(0, reward);
    }
}