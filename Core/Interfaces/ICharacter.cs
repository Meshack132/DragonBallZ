using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallZ.Core.Interfaces
{
    public interface ICharacter
    {
        string Name { get; }
        int PowerLevel { get; }
        void DisplayInfo();
        void PerformAttack();
        void ChangeTransformation(ITransformation newForm);
        void ChangeAttack(IAttackStrategy newAttack);
    }
}
