namespace RoleplayGame
{
    public class Dwarf : Character
    {
        public int AttackValue { get; set; }
        public int DefenseValue { get; }
        public NonMagicItem Item { get; set; }
        public Dwarf(string name, NonMagicItem item, int attackValue) : base(name)
        {
            this.Item = item;
            this.AttackValue = attackValue + item.AttackValue;
            this.DefenseValue = item.DefenseValue;
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
    }
}