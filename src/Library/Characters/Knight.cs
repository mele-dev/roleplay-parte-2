namespace RoleplayGame
{
    public class Knight : Character
    {
        public NonMagicItem Item { get; set; }
        public int DefenseValue { get; set; }
        public int AttackValue { get; set; }
        public Knight(string name, int attackValue, int defenseValue, NonMagicItem item) : base(name)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
            this.AttackValue = attackValue;
            this.Item = item;

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