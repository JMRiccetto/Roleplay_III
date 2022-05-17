namespace RoleplayGame
{
    public abstract class Item
    {
        public virtual int AttackValue { get; }

        public virtual int DefenseValue { get; }
    }
}