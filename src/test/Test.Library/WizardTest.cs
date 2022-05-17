    using NUnit.Framework;
    using RoleplayGame;

    namespace Test.Library
    {
        public class WizardTest
        {
            Wizard gandalf;

            Staff staff;

            SpellOne spell;

            SpellsBook spellsBook;

            [SetUp]
            public void Setup()
            {
                this.spellsBook = new SpellsBook();
                this.spell = new SpellOne();
                spellsBook.AddSpell(this.spell);
                this.gandalf = new Wizard("Gandalf");
                this.gandalf.AddItem(this.spellsBook);
            }

            //Test que demuestra que es posible asignar un nombre distinto.
            [Test]
            public void ValidNameTest()
            {
                this.gandalf.Name = "Merlín";
                Assert.AreEqual(this.gandalf.Name, "Merlín");
            }

            //Test que demuestra que es posible asignar una vida válida.
            [Test]
            public void ValidHealthTest()
            {
                Assert.AreEqual(this.gandalf.Health, 100);
            }

            //Test para saber el ataque de un personaje.
            [Test]
            public void AttackValue()
            {
                int expectedAttack = 170;
                Assert.AreEqual(expectedAttack, this.gandalf.AttackValue);
            }

            //Test para saber la defensa de un personaje.
            [Test]
            public void DefenseValueTest()
            {
                int expectedDefense = 170;
                Assert.AreEqual(expectedDefense, this.gandalf.DefenseValue);
            }

            //Test para verificar que un personaje puede atacar a otro personaje.
            [Test]
            public void AttackCharacterTest()
            {
                Archer legolas = new Archer("Legolas");
                legolas.ReceiveAttack(this.gandalf.AttackValue);
                int expectedHealth = 0;
                Assert.AreEqual(expectedHealth, legolas.Health);
            }

            //Test que demuestra que un personaje puede curarse correctamente.
            [Test]
            public void HealTest()
            {
                this.gandalf.ReceiveAttack(this.gandalf.AttackValue * 3);
                this.gandalf.Cure();
                Assert.AreEqual(this.gandalf.Health, 100);
            }

            //Test que demuestra que se le puede añadir un item nuevo a un personaje correctamente.
            [Test]
            public void AddItemTest()
            {

                this.staff = new Staff();
                this.gandalf.AddItem(staff);
                int expectedAttack = 270;
                Assert.AreEqual(this.gandalf.AttackValue, expectedAttack);
            }

            //Test que demuestra que se le puede remover un item nuevo a un personaje correctamente.
            [Test]
            public void RemoveItemTest()
            {    
                this.staff = new Staff();
                this.gandalf.AddItem(staff);
                this.gandalf.RemoveItem(staff);
                int expectedAttack = 170;
                Assert.AreEqual(this.gandalf.AttackValue, expectedAttack);
            }

            //Test que demuestra que se le puede añadir un item mágico nuevo a un personaje correctamente.
            [Test]
            public void AddMagicalItemTest()
            {
                SpellOne spell = new SpellOne();
                this.spellsBook.AddSpell(spell);
                int expectedAttack = 240;
                Assert.AreEqual(this.gandalf.AttackValue, expectedAttack);
            }

            //Test que demuestra que se le puede remover un item mágico nuevo a un personaje correctamente.
            [Test]
            public void RemoveMagicalItemTest()
            {        
                SpellOne spell = new SpellOne();
                this.spellsBook.AddSpell(spell);
                this.spellsBook.RemoveSpell(spell);
                int expectedAttack = 170;
                Assert.AreEqual(this.gandalf.AttackValue, expectedAttack);
            }
        }
    }