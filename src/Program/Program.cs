using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static async void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            MagicItem Staff = new MagicItem(230, 0);
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            NonMagicItem axe = new NonMagicItem(400, true);
            NonMagicItem helmet = new NonMagicItem(100, false);
            NonMagicItem shield = new NonMagicItem(500, false);

            NonMagicItem sword = new NonMagicItem(100, true);

            Console.WriteLine(sword.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
