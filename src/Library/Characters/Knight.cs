namespace RoleplayGame
{
    public class Knight : Character
    {
        public NonMagicItem Item { get; set; }
        public Knight(string name) : base(name)
        {

        }
        public int AttackValue
        {
            get
            {
                return Item.AttackValue;
            }
        }
        public int DefenseValue
        {
            get
            {
                return Item.DefenseValue;
            }
        }
        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
                this.Health -= power - this.DefenseValue;
            else
                this.Health = 0;
        }

    }
}