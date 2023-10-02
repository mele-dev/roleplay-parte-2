using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook spellsBook = new SpellsBook(0, 0);
            spellsBook.Spells = new Spell[] { new Spell("abracadabra", 100, 100), new Spell("espectro patronus", 500, 0) };

            MagicItem Staff = new MagicItem(230, 0);
            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Item = Staff;
            gandalf.SpellsBook = spellsBook;

            Dwarf gimli = new Dwarf("Gimli");
            NonMagicItem axe = new NonMagicItem(400, true);
            NonMagicItem helmet = new NonMagicItem(100, false);
            NonMagicItem shield = new NonMagicItem(500, false);
            NonMagicItem sword = new NonMagicItem(100, true);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
