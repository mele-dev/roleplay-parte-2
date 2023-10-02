using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : MagicItem
    {
        public SpellsBook(int attackValue, int defenseValue) : base(attackValue, defenseValue) { }

        public Spell[] Spells { get; set; }

        public new int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }
        public new int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
    }
}