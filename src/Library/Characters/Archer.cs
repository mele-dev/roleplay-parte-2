namespace RoleplayGame
{
    public class Archer : Character
    {
        public NonMagicItem item { get; set; }
        public int AttackValue { get; set; }
        public Archer(string name, int attackValue, NonMagicItem item) : base(name)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.item = item;
        }

        public int DefenseValue
        {
            get
            {
                return this.item.DefenseValue;
            }
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        /* public int AttackValue
        {
            get
            {
                return Bow.AttackValue;
            }
        } */

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

    }

}
