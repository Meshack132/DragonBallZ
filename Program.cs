using System;
using System.Collections.Generic;
using DragonBallZ.Core.Factory;
using DragonBallZ.Core.Interfaces;
using DragonBallZ.Transformations;
using DragonBallZ.Attacks;

namespace DragonBallZ.App
{
    class Program
    {
        private static CharacterCreator _creator = new CharacterCreator();
        private static List<ICharacter> _characters = new List<ICharacter>();
        private static Random _random = new Random();

        static void Main(string[] args)
        {
            Console.Title = "🔥 DRAGON BALL Z: TOURNAMENT OF POWER 🔥";
            PrintBanner();
            Pause();

            SeedCharacters();
            ShowMainMenu();
        }

        private static void PrintBanner()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║   🔥 DRAGON BALL Z: TOURNAMENT OF    ║");
            Console.WriteLine("║            ⚡ POWER ⚡                ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  Welcome
