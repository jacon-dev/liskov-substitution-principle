using System;
using NUnit.Framework.Constraints;

namespace LiskovSubstitutionPrinciple
{
    public class DuckControls
    {
        public bool MathTheDuckSwim(Duck duck)
        {
            var isSwimming = duck.Swim();
            return isSwimming;
        }

        public string MakeTheDuckQuack(Duck duck)
        {
            var duckQuack = duck.MakeNoise();
            return duckQuack;
        }
    }

    public abstract class Duck
    {
        public abstract bool Swim();
        public abstract string MakeNoise();
    }

    public class RealDuck : Duck
    {
        public override bool Swim()
        {
            return true;
        }

        public override string MakeNoise()
        {
            return "Quack!";
        }
    }

    public class ToyDuck : Duck
    {
        private bool _isTurnedOn;
        
        public override bool Swim()
        {
            if (_isTurnedOn) return true;
            return false;
        }

        public override string MakeNoise()
        {
            if (_isTurnedOn) return "Techno Quack!";
            return null;
        }
    }
}