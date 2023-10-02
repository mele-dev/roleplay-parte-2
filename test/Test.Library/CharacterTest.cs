using NUnit.Framework;
using RoleplayGame;

namespace Library.Test;

public class CharacterTest
{
    [TestCase("Juancito", 100, 80)]
    [TestCase("Pedro", 100, 50)]
    [TestCase("Juanita", 100, 99)]
    public void CorrectCure(string name, int expected, int attackValue)
    {
        Character wizard = new Wizard(name);
        wizard.ReceiveAttack(attackValue);

        wizard.Cure();
        int result = wizard.Health;

        Assert.That(result, Is.EqualTo(expected));
    }


}