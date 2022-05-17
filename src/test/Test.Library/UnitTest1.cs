using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class KnightTest
    {
        Knight arthur;

        Sword sword;

        Shield shield;

        Armor armor;

        [SetUp]
        public void Setup()
        {
            this.arthur = new Knight("arthur");
            this.sword = new Sword();
            this.shield = new Shield();
            this.armor = new Armor();
            this.arthur.AddItem(sword);
            this.arthur.AddItem(shield);
            this.arthur.AddItem(armor);
        }

//Test que demuestra que es posible asignar un nombre distinto.
        [Test]
        public void ValidNameTest()
        {
            this.arthur.Name = "Benjamin";
            Assert.AreEqual(this.arthur.Name, "Benjamin");
        }

        //Test que demuestra que es posible asignar una vida válida.
        [Test]
        public void ValidHealthTest()
        {
            Assert.AreEqual(this.arthur.Health, 100);
        }

        //Test para saber el ataque de un personaje.
        [Test]
        public void AttackValue()
        {
            int expectedAttack = 40;
            Assert.AreEqual(expectedAttack, this.arthur.AttackValue);
        }

        //Test para saber la defensa de un personaje.
        [Test]
        public void DefenseValueTest()
        {
            int expectedDefense = 78;
            Assert.AreEqual(expectedDefense, this.arthur.DefenseValue);
        }

        //Test para verificar que un personaje puede atacar a otro personaje.
        [Test]
        public void AttackCharacterTest()
        {
            Knight fernando = new Knight("Fernando");
            fernando.AddItem(sword);
            fernando.AddItem(shield);
            fernando.AddItem(armor);
            fernando.ReceiveAttack(this.arthur.AttackValue);
            int expectedHealth = 100;
            Assert.AreEqual(expectedHealth, fernando.Health);
        }

        //Test que demuestra que un personaje puede curarse correctamente.
        [Test]
        public void HealTest()
        {
            this.arthur.ReceiveAttack(this.arthur.AttackValue * 3);
            this.arthur.Cure();
            Assert.AreEqual(this.arthur.Health, 100);
        }
    }
}