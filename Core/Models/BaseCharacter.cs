using System;
using DragonBallZ.Core.Interfaces;

namespace DragonBallZ.Core.Models
{
    public class BaseCharacter : ICharacter
    {
        public string Name { get; }
        public int PowerLevel { get; private set; }
        private ITransformation _currentTransformation;
        private IAttackStrategy _attackStrategy;

        public BaseCharacter(string name, int basePower, ITransformation startingForm, IAttackStrategy attack)
        {
            Name = name;
            PowerLevel = basePower;
            _currentTransformation = startingForm;
            _attackStrategy = attack;
        }

        public void ChangeTransformation(ITransformation newForm)
        {
            _currentTransformation = newForm;
            Console.WriteLine($"{Name} changes to {_currentTransformation.Name}!");
            _currentTransformation.Transform();
            PowerLevel *= newForm.PowerMultiplier;
        }

        public void ChangeAttack(IAttackStrategy newAttack)
        {
            _attackStrategy = newAttack;
            Console.WriteLine($"{Name} learns {newAttack.AttackName}!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n{Name}");
            Console.WriteLine($"Power Level: {PowerLevel:N0}");
            Console.WriteLine($"Current Form: {_currentTransformation.Name}");
            Console.WriteLine($"Special Attack: {_attackStrategy.AttackName}");
        }

        public void PerformAttack()
        {
            Console.WriteLine($"\n{Name} prepares to attack...");
            _attackStrategy.Execute();
        }
    }
}
