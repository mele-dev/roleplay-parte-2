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
    }
}