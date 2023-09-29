namespace RoleplayGame;

public abstract class Character
{
    public int health = 100;
    public string Name { get; set; }

    public Character(string name)
    {
        this.Name = name;
    }
    public abstract void ReceiveAttack(int power);
    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            this.health = value < 0 ? 0 : value;
        }
    }
    public void Cure()
    {
        this.Health = 100;
    }


}