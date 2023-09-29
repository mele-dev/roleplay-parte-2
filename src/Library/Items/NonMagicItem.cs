using System;

namespace RoleplayGame
{
    public class NonMagicItem
    {
        public int DefenseValue = 0;
        public int AttackValue = 0;
        public NonMagicItem(int value, bool attackOrDefense)
        {
            // supongamos que true indica que ataca y false defiende
            if (attackOrDefense)
                this.AttackValue = value;
            else
                this.DefenseValue = value;
        }

        public void ValidateItem()
        {
            if (this.AttackValue > 0 && this.DefenseValue > 0)
            {
                throw new Exception("Uno de los dos valores debe ser 0.");
            }
        }

    }
}