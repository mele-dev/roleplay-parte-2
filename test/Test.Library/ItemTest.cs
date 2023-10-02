using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class ItemTest
    {
        [TestCase(200, false, 200)]
        [TestCase(200, true, 0)]
        public void ItemDefense(int attackValue, bool state, int expected)
        {
            NonMagicItem item = new NonMagicItem(attackValue, state);

            Assert.That(item.DefenseValue, Is.EqualTo(expected));



        }

        [TestCase(200, false, 0)]
        [TestCase(200, true, 200)]
        public void ItemAttack(int attackValue, bool state, int expected)
        {
            NonMagicItem item = new NonMagicItem(attackValue, state);

            Assert.That(item.AttackValue, Is.EqualTo(expected));



        }

        [Test]
        public void SpellsBookDefense()
        {
            SpellsBook spellsBook = new SpellsBook(0, 0);
            spellsBook.Spells = new Spell[] { new Spell("abracadabra", 100, 100), new Spell("espectro patronus", 500, 0) };

            Assert.That(spellsBook.DefenseValue, Is.EqualTo(100));


        }

        [Test]
        public void SpellsBookAttack()
        {
            SpellsBook spellsBook = new SpellsBook(0, 0);
            spellsBook.Spells = new Spell[] { new Spell("abracadabra", 300, 200), new Spell("espectro patronus", 500, 220) };

            Assert.That(spellsBook.AttackValue, Is.EqualTo(800));


        }



    }



}