using DragonBallZ.Attacks;
using DragonBallZ.Core.Interfaces;
using DragonBallZ.Core.Models;
using DragonBallZ.Transformations;

namespace DragonBallZ.Core.Factory
{
    public class CharacterCreator
    {
        public ICharacter CreateGoku() =>
            new BaseCharacter("Son Goku", 10000, new NormalForm(), new Kamehameha());

        public ICharacter CreateVegeta() =>
            new BaseCharacter("Vegeta", 9500, new NormalForm(), new FinalFlash());

        public ICharacter CreateBeerus() =>
            new BaseCharacter("Beerus", 2000000, new NormalForm(), new Hakai());

        public ICharacter CreateJiren() =>
            new BaseCharacter("Jiren", 8000000, new NormalForm(), new PowerImpact());

        public ICharacter CreateToppo() =>
            new BaseCharacter("Toppo", 4000000, new GodOfDestructionForm(), new JusticeFlash());

        public ICharacter CreateHit() =>
            new BaseCharacter("Hit", 3000000, new NormalForm(), new TimeCage());

        public ICharacter CreateFrieza() =>
            new BaseCharacter("Golden Frieza", 2800000, new SuperSaiyanBlue(), new DeathBeam());
    }
}