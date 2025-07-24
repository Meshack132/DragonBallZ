using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallZ.Core.Interfaces
{
    public interface IAttackStrategy
    {
        string AttackName { get; }
        void Execute();
    }
}