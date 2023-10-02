namespace RoleplayGame;

public class MagicItem
{
    public int DefenseValue { get; set; }
    public int AttackValue { get; set; }
    public MagicItem(int attackValue, int defenseValue)
    {
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
    }

}