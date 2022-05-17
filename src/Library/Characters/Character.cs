namespace RoleplayGame
{
    public abstract class Character
    {
        string Name { get; set; }

        int Health { get; }

        int AttackValue { get; }

        int DefenseValue { get; }

        public abstract void AddItem(Item item);

        public abstract void RemoveItem(Item item);

        public abstract void Cure();

        public abstract void ReceiveAttack(int power);
    }
}