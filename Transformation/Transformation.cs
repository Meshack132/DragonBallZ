using System;
using DragonBallZ.Core.Interfaces;

namespace DragonBallZ.Transformations
{
    public class NormalForm : ITransformation
    {
        public string Name => "Normal Form";
        public int PowerMultiplier => 1;
        public void Transform() => Console.WriteLine("Energy stabilizes at base level.");
    }

    public class SuperSaiyan : ITransformation
    {
        public string Name => "Super Saiyan";
        public int PowerMultiplier => 50;
        public void Transform() => Console.WriteLine("Hair turns gold! Energy surges!");
    }

    public class SuperSaiyanBlue : ITransformation
    {
        public string Name => "Super Saiyan Blue";
        public int PowerMultiplier => 500;
        public void Transform() => Console.WriteLine("Aura turns blue! Divine energy radiates!");
    }

    public class UltraInstinct : ITransformation
    {
        public string Name => "Ultra Instinct";
        public int PowerMultiplier => 1000;
        public void Transform() => Console.WriteLine("Silver aura! Movements become instinctive!");
    }

    public class GodOfDestructionForm : ITransformation
    {
        public string Name => "God of Destruction Form";
        public int PowerMultiplier => 1200;
        public void Transform() => Console.WriteLine("Godly energy intensifies! Chaos looms.");
    }
}
