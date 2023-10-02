using NUnit.Framework;
using RoleplayGame;

namespace Library.Test;

public class WizardTests
{
    [Test]
    public void CorrectReceiveAttack()
    {
        Wizard Harry = new Wizard("Harry");
        MagicItem Staff = new MagicItem(50, 50);
        Harry.Item = Staff;
        Harry.ReceiveAttack(100);

        int expected = 50;
        int result = Harry.Health;

        Assert.That(result, Is.EqualTo(expected));

    }
}