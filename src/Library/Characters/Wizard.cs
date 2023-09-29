namespace RoleplayGame
{
    public class Wizard : Character
    {
        public MagicItem Item { get; set; }
        public int AttackValue { get; set; }
        public Wizard(string name, MagicItem item, int attackValue) : base(name)
        {
            this.Item = item;
            this.AttackValue = attackValue + item.AttackValue;
        }
        public SpellsBook SpellsBook { get; set; }

        public int AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + Staff.AttackValue;
            }
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Staff.DefenseValue;
            }
        }


    }
}