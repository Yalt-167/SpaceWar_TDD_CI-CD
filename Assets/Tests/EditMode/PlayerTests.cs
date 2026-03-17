using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class PlayerTests
{
    private Player player;

    [SetUp]
    public void SetUp()
    {
        player = new Player();   // Arrange — initialisation
    }

    // ─── ETAPE 1 : RED — ce test doit echouer ───────────
    [Test]
    public void TakeDamage_Normal_ReducesHealth()
    {
        int damage = 20;

        player.TakeDamage(damage);

        Assert.AreEqual(80, player.Health);
    }

    [Test]
    public void TakeDamage_WithFatalDamage_SetsHealthToZero()
    {
        player.TakeDamage(200);

        Assert.AreEqual(0, player.Health);
    }

    [Test]
    public void TakeDamage_WithNegativeAmount_DoesNotChangeHealth()
    {
        player.TakeDamage(-10);

        Assert.AreEqual(100, player.Health);
    }

    [Test]
    public void Heal_WhenHealthBelow100_IncreasesHealth()
    {
        player.TakeDamage(50);

        player.Heal(20);

        Assert.AreEqual(70, player.Health);
    }

    [Test]
    public void Heal_WhenAlreadyFullHealth_DoesNotExceed100()
    {
        player.Heal(50);

        Assert.AreEqual(100, player.Health);
    }

    [Test]
    public void IsAlive_WhenHealthIsZero_ReturnsFalse()
    {
        player.TakeDamage(200);

        Assert.IsFalse(player.IsAlive);
    }

    [Test]
    public void LoseLife_WhenLastLife_IsAliveReturnsFalse()
    {
        player.LoseLife();
        player.LoseLife();
        player.LoseLife();

        Assert.IsFalse(player.IsAlive);
    }

}



