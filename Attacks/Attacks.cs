using System;
using DragonBallZ.Core.Interfaces;

namespace DragonBallZ.Attacks
{
    public class Kamehameha : IAttackStrategy
    {
        public string AttackName => "Kamehameha";
        public int PowerLevel => 9000;
        public int EnergyCost => 30;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[{AttackName}] KA...ME...HA...ME...HAAAAA!!! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class FinalFlash : IAttackStrategy
    {
        public string AttackName => "Final Flash";
        public int PowerLevel => 8500;
        public int EnergyCost => 35;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{AttackName}] FINAL FLASH!!! Massive energy beam erupts! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class SpiritBomb : IAttackStrategy
    {
        public string AttackName => "Spirit Bomb";
        public int PowerLevel => 12000;
        public int EnergyCost => 60;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[{AttackName}] Gathering energy from all living things... (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class Hakai : IAttackStrategy
    {
        public string AttackName => "Hakai";
        public int PowerLevel => 15000;
        public int EnergyCost => 80;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"[{AttackName}] ERASE! Target disintegrates with divine energy! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class JusticeFlash : IAttackStrategy
    {
        public string AttackName => "Justice Flash";
        public int PowerLevel => 5000;
        public int EnergyCost => 20;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[{AttackName}] Toppo unleashes a barrage of justice blasts! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class PowerImpact : IAttackStrategy
    {
        public string AttackName => "Power Impact";
        public int PowerLevel => 11000;
        public int EnergyCost => 40;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{AttackName}] Jiren fires a devastating energy sphere! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class TimeCage : IAttackStrategy
    {
        public string AttackName => "Time Cage";
        public int PowerLevel => 7000;
        public int EnergyCost => 50;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"[{AttackName}] Hit traps the enemy in a time-lock zone! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class DestructionSphere : IAttackStrategy
    {
        public string AttackName => "Destruction Sphere";
        public int PowerLevel => 9500;
        public int EnergyCost => 45;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"[{AttackName}] An energy orb forms, radiating pure annihilation! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class DeathBeam : IAttackStrategy
    {
        public string AttackName => "Death Beam";
        public int PowerLevel => 7500;
        public int EnergyCost => 25;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"[{AttackName}] Frieza fires a piercing Death Beam! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    // --- New Attacks ---

    public class GalickGun : IAttackStrategy
    {
        public string AttackName => "Galick Gun";
        public int PowerLevel => 8800;
        public int EnergyCost => 32;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"[{AttackName}] Vegeta charges and blasts a massive purple beam! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }

    public class DestructoDisc : IAttackStrategy
    {
        public string AttackName => "Destructo Disc";
        public int PowerLevel => 6500;
        public int EnergyCost => 18;
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{AttackName}] Krillin hurls a razor-sharp energy disc! (Power: {PowerLevel} | Cost: {EnergyCost} Ki)");
            Console.ResetColor();
        }
    }
}
