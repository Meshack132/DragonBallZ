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

        static void Main(string[] args)
        {
            Console.Title = "🔥 DRAGON BALL Z: TOURNAMENT OF POWER 🔥";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWelcome, Warrior! Prepare for the Tournament of Power!");
            Console.ResetColor();
            Pause();

            SeedCharacters();
            ShowMainMenu();
        }

        private static void SeedCharacters()
        {
            _characters.Add(_creator.CreateGoku());
            _characters.Add(_creator.CreateVegeta());
            _characters.Add(_creator.CreateBeerus());
            _characters.Add(_creator.CreateJiren());
            _characters.Add(_creator.CreateToppo());
            _characters.Add(_creator.CreateHit());
            _characters.Add(_creator.CreateFrieza());
        }

        private static void ShowMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==============================");
                Console.WriteLine(" DRAGON BALL Z - MAIN CONTROL ");
                Console.WriteLine("==============================");
                Console.ResetColor();
                Console.WriteLine("1. View Fighters");
                Console.WriteLine("2. Epic 1v1 Battle");
                Console.WriteLine("3. Power Up Transformation");
                Console.WriteLine("4. Teach New Special Move");
                Console.WriteLine("5. Exit Arena");
                Console.Write("Choose your action, Saiyan: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DisplayAllCharacters();
                        break;
                    case "2":
                        SimulateBattle();
                        break;
                    case "3":
                        TransformCharacter();
                        break;
                    case "4":
                        TeachNewAttack();
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nFarewell, Warrior! Train harder and return stronger!");
                        Console.ResetColor();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid move! Press Enter to regroup.");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void DisplayAllCharacters()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--- TOURNAMENT ROSTER ---");
            Console.ResetColor();
            foreach (var character in _characters)
                character.DisplayInfo();
            Pause();
        }

        private static void SimulateBattle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("⚔️  Choose your fighters for an epic duel!");
            Console.ResetColor();
            DisplayCharacterList();

            int first = GetCharacterIndex("First Champion");
            int second = GetCharacterIndex("Second Champion");

            var fighter1 = _characters[first];
            var fighter2 = _characters[second];

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n🔥 {fighter1.Name} VS {fighter2.Name} 🔥");
            Console.ResetColor();
            Console.WriteLine("\n--- COMBAT INITIATED ---\n");
            fighter1.PerformAttack();
            fighter2.PerformAttack();

            string winner;
            if (fighter1.PowerLevel == fighter2.PowerLevel)
            {
                winner = "It's a tie! The universe trembles!";
            }
            else
            {
                winner = fighter1.PowerLevel > fighter2.PowerLevel ? fighter1.Name : fighter2.Name;
                winner += " wins the clash of titans!";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n🏆 {winner}");
            Console.ResetColor();
            Pause();
        }

        private static void TransformCharacter()
        {
            Console.Clear();
            DisplayCharacterList();
            int index = GetCharacterIndex("Select warrior to transform");

            Console.WriteLine("Available Transformations:");
            Console.WriteLine("1. Super Saiyan\n2. Super Saiyan Blue\n3. Ultra Instinct\n4. God of Destruction Form");
            Console.Write("Choose your transformation: ");
            var input = Console.ReadLine();
            ITransformation transformation = input switch
            {
                "1" => new SuperSaiyan(),
                "2" => new SuperSaiyanBlue(),
                "3" => new UltraInstinct(),
                "4" => new GodOfDestructionForm(),
                _ => null
            };

            if (transformation == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice. Transformation failed.");
                Console.ResetColor();
            }
            else
            {
                _characters[index].ChangeTransformation(transformation);
            }
            Pause();
        }

        private static void TeachNewAttack()
        {
            Console.Clear();
            DisplayCharacterList();
            int index = GetCharacterIndex("Train which warrior?");

            Console.WriteLine("Available Special Attacks:");
            Console.WriteLine("1. Kamehameha\n2. Final Flash\n3. Spirit Bomb\n4. Hakai\n5. Justice Flash\n6. Power Impact\n7. Time Cage\n8. Death Beam");
            Console.Write("Choose the new move: ");
            var input = Console.ReadLine();

            IAttackStrategy attack = input switch
            {
                "1" => new Kamehameha(),
                "2" => new FinalFlash(),
                "3" => new SpiritBomb(),
                "4" => new Hakai(),
                "5" => new JusticeFlash(),
                "6" => new PowerImpact(),
                "7" => new TimeCage(),
                "8" => new DeathBeam(),
                _ => null
            };

            if (attack == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid move. Training aborted.");
                Console.ResetColor();
            }
            else
            {
                _characters[index].ChangeAttack(attack);
            }
            Pause();
        }

        private static void DisplayCharacterList()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < _characters.Count; i++)
                Console.WriteLine($"{i + 1}. {_characters[i].Name}");
            Console.ResetColor();
        }

        private static int GetCharacterIndex(string prompt)
        {
            Console.Write($"{prompt} (1-{_characters.Count}): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > _characters.Count)
            {
                Console.Write("Invalid selection. Try again: ");
            }
            return choice - 1;
        }

        private static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
