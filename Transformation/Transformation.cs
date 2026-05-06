using System;
using DragonBallZ.Core.Interfaces;

namespace DragonBallZ.Transformations
{
    public class NormalForm : ITransformation
    {
        public string Name => "Normal Form";
        public int PowerMultiplier => 1;
        public string EnergyAura => "None";
        public int StaminaCost => 0;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[{Name}] Energy stabilizes at base level. (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class SuperSaiyan : ITransformation
    {
        public string Name => "Super Saiyan";
        public int PowerMultiplier => 50;
        public string EnergyAura => "Golden";
        public int StaminaCost => 10;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{Name}] Hair turns gold! Energy surges! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class SuperSaiyan2 : ITransformation
    {
        public string Name => "Super Saiyan 2";
        public int PowerMultiplier => 100;
        public string EnergyAura => "Electric Gold";
        public int StaminaCost => 20;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{Name}] Lightning crackles around the golden aura! Power doubled! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class SuperSaiyan3 : ITransformation
    {
        public string Name => "Super Saiyan 3";
        public int PowerMultiplier => 400;
        public string EnergyAura => "Blazing Gold";
        public int StaminaCost => 50;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"[{Name}] Eyebrows vanish! Hair extends endlessly! Raw power overwhelming! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class SuperSaiyanGod : ITransformation
    {
        public string Name => "Super Saiyan God";
        public int PowerMultiplier => 250;
        public string EnergyAura => "Crimson Red";
        public int StaminaCost => 35;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{Name}] Hair turns red! Divine energy awakens within! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class SuperSaiyanBlue : ITransformation
    {
        public string Name => "Super Saiyan Blue";
        public int PowerMultiplier => 500;
        public string EnergyAura => "Divine Blue";
        public int StaminaCost => 45;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[{Name}] Aura turns blue! Divine energy radiates! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class UltraInstinct : ITransformation
    {
        public string Name => "Ultra Instinct";
        public int PowerMultiplier => 1000;
        public string EnergyAura => "Silver";
        public int StaminaCost => 70;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"[{Name}] Silver aura! Movements become instinctive! Mind and body separated! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class TrueUltraInstinct : ITransformation
    {
        public string Name => "True Ultra Instinct";
        public int PowerMultiplier => 1500;
        public string EnergyAura => "Black & Silver";
        public int StaminaCost => 90;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"[{Name}] Dark aura erupts! Emotion and instinct fuse into ultimate power! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class GodOfDestructionForm : ITransformation
    {
        public string Name => "God of Destruction Form";
        public int PowerMultiplier => 1200;
        public string EnergyAura => "Purple Destruction";
        public int StaminaCost => 80;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"[{Name}] Godly energy intensifies! Chaos looms. All shall be erased! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }

    public class BeastForm : ITransformation
    {
        public string Name => "Beast Form";
        public int PowerMultiplier => 1800;
        public string EnergyAura => "Red & White";
        public int StaminaCost => 85;
        public void Transform()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"[{Name}] Gohan's hidden power fully awakens! Beast instinct takes over! (Multiplier: x{PowerMultiplier} | Aura: {EnergyAura} | Stamina Cost: {StaminaCost})");
            Console.ResetColor();
        }
    }
}
