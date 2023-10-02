namespace RoleplayGame
{
    public class Wizard : Character
    {
        public MagicItem Item { get; set; }
        public SpellsBook SpellsBook { get; set; }
        public Wizard(string name) : base(name) { }
        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
                this.Health -= power - this.DefenseValue;
            else
                this.Health = 0;
        }

        public int AttackValue
        {
            get
            {
                // aplicamos la misma logica que en DefenseValue
                int spellsBookAttackValue = SpellsBook?.AttackValue ?? 0;
                return spellsBookAttackValue += Item?.AttackValue ?? 0;
            }
        }

        public int DefenseValue
        {
            get
            {
                /* primero validamos que exista el objeto SpellsBook, en caso
                 * de que exista tomamos su atributo DefenseValue, sino
                 * asignamos a la variable spellsBookDefenseValue el
                 * valor 0. Luego, retornamos la suma de spellsBookDefenseValue
                 * y el DefenseValue de Item solo si Item existe,
                 * de caso contrario se retorna spellsBookDefenseValue + 0.
                 * (recordemos que en el caso de que ambos objetos NO existan,
                 * se retorna 0 + 0) */
                int spellsBookDefenseValue = SpellsBook?.DefenseValue ?? 0;
                return spellsBookDefenseValue += Item?.DefenseValue ?? 0;
            }
        }
    }
}