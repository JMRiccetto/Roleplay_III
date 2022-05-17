using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Character
    {
        private int health = 100;

        private List<Item> items = new List<Item>();

        public Archer(string name)
        {
            this.Name = name;
            
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }

        public string Name { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.items)
                {
                    if (item is Item)
                    {
                        value += (item as Item).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.items)
                {
                    if (item is Item)
                    {
                        value += (item as Item).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }

        public override void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public override void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }
    }
}