using System;
using DragonBallZ.Attacks;
using DragonBallZ.Core.Interfaces;

namespace DragonBallZ.Scenes
{
    public static class EpicBattleScenario
    {
        public static void Run(ICharacter goku, ICharacter vegeta, ICharacter beerus)
        {
            Console.WriteLine("\n=== EPIC BATTLE ===");
            Console.WriteLine("Goku and Vegeta team up against Beerus!");

            goku.ChangeAttack(new SpiritBomb());
            vegeta.ChangeAttack(new FinalFlash());

            Console.WriteLine("\nGoku:");
            goku.PerformAttack();

            Console.WriteLine("\nVegeta:");
            vegeta.PerformAttack();

            Console.WriteLine("\nBeerus:");
            beerus.PerformAttack();

            Console.WriteLine("\nThe battle shakes the universe!");
        }
    }
}
