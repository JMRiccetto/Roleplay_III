namespace RoleplayGame
{
    public abstract class Spell : MagicalItem
    {
        public override int AttackValue { get; }

        public override int DefenseValue { get; }
    }
}