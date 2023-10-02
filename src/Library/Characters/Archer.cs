namespace RoleplayGame
{
    public class Archer : Character
    {
        public NonMagicItem Item { get; set; }
        public Archer(string name) : base(name)
        {
        }

        public int DefenseValue
        {
            get
            {
                return this.Item.DefenseValue;
            }
        }

        public int AttackValue
        {
            get
            {
                return this.Item.AttackValue;
            }
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
