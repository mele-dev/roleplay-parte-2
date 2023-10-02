namespace RoleplayGame
{
    public class Archer : Character
    {
        public NonMagicItem Item { get; set; }
        public Archer(string name) : base(name)
        {
        }

        public int AttackValue
        {
            get
            {
                return Item.AttackValue += Item?.AttackValue ?? 0;
            }
        }
        public int DefenseValue
        {
            get
            {
                return Item.DefenseValue += Item?.DefenseValue ?? 0;
            }
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
            else
                this.Health = 0;
        }
    }
}
