using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallZ.Core.Interfaces
{
    public interface ITransformation
    {
        string Name { get; }
        int PowerMultiplier { get; }
        void Transform();
    }
}