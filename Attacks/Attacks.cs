using System;
using DragonBallZ.Core.Interfaces;

namespace DragonBallZ.Attacks
{
    public class Kamehameha : IAttackStrategy
    {
        public string AttackName => "Kamehameha";
        public void Execute() => Console.WriteLine("KA...ME...HA...ME...HAAAAA!!!");
    }

    public class FinalFlash : IAttackStrategy
    {
        public string AttackName => "Final Flash";
        public void Execute() => Console.WriteLine("FINAL FLASH!!! Massive energy beam erupts!");
    }

    public class SpiritBomb : IAttackStrategy
    {
        public string AttackName => "Spirit Bomb";
        public void Execute() => Console.WriteLine("Gathering energy from all living things...");
    }

    public class Hakai : IAttackStrategy
    {
        public string AttackName => "Hakai";
        public void Execute() => Console.WriteLine("ERASE! Target disintegrates with divine energy!");
    }

    public class JusticeFlash : IAttackStrategy
    {
        public string AttackName => "Justice Flash";
        public void Execute() => Console.WriteLine("Toppo unleashes a barrage of justice blasts!");
    }

    public class PowerImpact : IAttackStrategy
    {
        public string AttackName => "Power Impact";
        public void Execute() => Console.WriteLine("Jiren fires a devastating energy sphere!");
    }

    public class TimeCage : IAttackStrategy
    {
        public string AttackName => "Time Cage";
        public void Execute() => Console.WriteLine("Hit traps the enemy in a time-lock zone!");
    }

    public class DestructionSphere : IAttackStrategy
    {
        public string AttackName => "Destruction Sphere";
        public void Execute() => Console.WriteLine("An energy orb forms, radiating pure annihilation!");
    }

    public class DeathBeam : IAttackStrategy
    {
        public string AttackName => "Death Beam";
        public void Execute() => Console.WriteLine("Frieza fires a piercing Death Beam!");
    }
}
