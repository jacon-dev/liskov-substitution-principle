using NUnit.Framework;

namespace LiskovSubstitutionPrinciple
{
    [TestFixture]
    public class DuckControlsTests
    {
        [Test]
        public void TestThatRealDuckCanSwim()
        {
            var sut = new DuckControls();
            var duck = new RealDuck();
            
            Assert.IsTrue(sut.MathTheDuckSwim(duck));
        }        
        
        [Test]
        public void TestThatRealDuckQuacks()
        {
            var sut = new DuckControls();
            var duck = new RealDuck();
            
            Assert.AreEqual("Quack!", sut.MakeTheDuckQuack(duck));
        }

        [Test]
        public void TestThatToyDuckCanSwim()
        {
            var sut = new DuckControls();
            var duck = new ToyDuck();
            
            Assert.IsTrue(sut.MathTheDuckSwim(duck));
        }

        [Test]
        public void TestThatToyDuckQuacks()
        {
            var sut = new DuckControls();
            var duck = new ToyDuck();
            
            Assert.AreEqual("Techno Quack!", sut.MakeTheDuckQuack(duck));
        }
    }
}