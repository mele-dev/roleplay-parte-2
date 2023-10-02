using System.Diagnostics.Contracts;

namespace RoleplayGame
{
    public class Spell
    {
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public string Name { get; set; }
        public Spell(string name, int attackValue, int defenseValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
            this.Name = name;
        }
    }
}