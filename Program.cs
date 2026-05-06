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
            Console.Title = "DRAGON BALL Z: TOURNAMENT OF POWER";
            PrintBanner();
            Pause();
            SeedCharacters();
            ShowMainMenu();
        }

        private static void PrintBanner()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║   DRAGON BALL Z: TOURNAMENT OF       ║");
            Console.WriteLine("║            ** POWER **               ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  Welcome, Warrior! Prepare for battle!");
            Console.ResetColor();
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
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║     DRAGON BALL Z - MAIN CONTROL     ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.ResetColor();
                Console.WriteLine("  1. View Fighters");
                Console.WriteLine("  2. Epic 1v1 Battle");
                Console.WriteLine("  3. Tournament Mode (All vs All)");
                Console.WriteLine("  4. Power Up Transformation");
                Console.WriteLine("  5. Teach New Special Move");
                Console.WriteLine("  6. Fighter Stats Comparison");
                Console.WriteLine("  7. Exit Arena");
                Console.Write("\nChoose your action, Saiyan: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1": DisplayAllCharacters(); break;
                    case "2": SimulateBattle(); break;
                    case "3": TournamentMode(); break;
                    case "4": TransformCharacter(); break;
                    case "5": TeachNewAttack(); break;
                    case "6": CompareStats(); break;
                    case "7":
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
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║         TOURNAMENT ROSTER            ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ResetColor();
            foreach (var character in _characters)
                character.DisplayInfo();
            Pause();
        }

        private static void SimulateBattle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Choose your fighters for an epic duel!");
            Console.ResetColor();
            DisplayCharacterList();

            int first = GetCharacterIndex("First Champion");
            int second = GetCharacterIndex("Second Champion");

            if (first == second)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A warrior cannot fight themselves! Choose different fighters.");
                Console.ResetColor();
                Pause();
                return;
            }

            var fighter1 = _characters[first];
            var fighter2 = _characters[second];

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n*** {fighter1.Name} VS {fighter2.Name} ***");
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();

            Console.WriteLine("\n--- ROUND 1: ATTACKS ---\n");
            fighter1.PerformAttack();
            System.Threading.Thread.Sleep(800);
            fighter2.PerformAttack();
            System.Threading.Thread.Sleep(800);

            Console.WriteLine("\n--- ROUND 2: POWER CLASH ---\n");
            PrintPowerBar(fighter1.Name, fighter1.PowerLevel);
            PrintPowerBar(fighter2.Name, fighter2.PowerLevel);

            Console.WriteLine();
            string winner;
            if (fighter1.PowerLevel == fighter2.PowerLevel)
            {
                winner = _random.Next(2) == 0 ? fighter1.Name : fighter2.Name;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Powers are equal! The universe decides...");
                Console.ResetColor();
                winner += " wins by a hair!";
            }
            else
            {
                winner = fighter1.PowerLevel > fighter2.PowerLevel ? fighter1.Name : fighter2.Name;
                winner += " wins the clash of titans!";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[WINNER] {winner}");
            Console.ResetColor();
            Pause();
        }

        private static void TournamentMode()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TOURNAMENT OF POWER -- ALL VS ALL");
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();

            var scores = new Dictionary<string, int>();
            foreach (var c in _characters)
                scores[c.Name] = 0;

            for (int i = 0; i < _characters.Count; i++)
            {
                for (int j = i + 1; j < _characters.Count; j++)
                {
                    var f1 = _characters[i];
                    var f2 = _characters[j];
                    string matchWinner;

                    if (f1.PowerLevel == f2.PowerLevel)
                        matchWinner = _random.Next(2) == 0 ? f1.Name : f2.Name;
                    else
                        matchWinner = f1.PowerLevel > f2.PowerLevel ? f1.Name : f2.Name;

                    scores[matchWinner]++;
                    Console.WriteLine($"  {f1.Name} vs {f2.Name} -> {matchWinner}");
                    System.Threading.Thread.Sleep(300);
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("           FINAL STANDINGS");
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();

            var sorted = new List<KeyValuePair<string, int>>(scores);
            sorted.Sort((a, b) => b.Value.CompareTo(a.Value));

            int rank = 1;
            foreach (var entry in sorted)
            {
                string medal = rank == 1 ? "[1st]" : rank == 2 ? "[2nd]" : rank == 3 ? "[3rd]" : "     ";
                Console.WriteLine($"  {medal} #{rank} {entry.Key} - {entry.Value} wins");
                rank++;
            }

            Pause();
        }

        private static void CompareStats()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("FIGHTER STATS COMPARISON");
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();
            DisplayCharacterList();

            int first = GetCharacterIndex("First Fighter");
            int second = GetCharacterIndex("Second Fighter");

            var f1 = _characters[first];
            var f2 = _characters[second];

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n  {"Stat",-20} {f1.Name,-20} {f2.Name,-20}");
            Console.WriteLine("  " + new string('-', 60));
            Console.ResetColor();
            Console.WriteLine($"  {"Power Level",-20} {f1.PowerLevel,-20} {f2.PowerLevel,-20}");

            Console.WriteLine("\n  Power Bars:");
            PrintPowerBar(f1.Name, f1.PowerLevel);
            PrintPowerBar(f2.Name, f2.PowerLevel);

            Pause();
        }

        private static void TransformCharacter()
        {
            Console.Clear();
            DisplayCharacterList();
            int index = GetCharacterIndex("Select warrior to transform");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nAvailable Transformations:");
            Console.ResetColor();
            Console.WriteLine("  1. Super Saiyan         (x50)");
            Console.WriteLine("  2. Super Saiyan 2       (x100)");
            Console.WriteLine("  3. Super Saiyan 3       (x400)");
            Console.WriteLine("  4. Super Saiyan God     (x250)");
            Console.WriteLine("  5. Super Saiyan Blue    (x500)");
            Console.WriteLine("  6. Ultra Instinct       (x1000)");
            Console.WriteLine("  7. True Ultra Instinct  (x1500)");
            Console.WriteLine("  8. God of Destruction   (x1200)");
            Console.WriteLine("  9. Beast Form           (x1800)");
            Console.Write("\nChoose your transformation: ");

            var input = Console.ReadLine();
            ITransformation transformation = input switch
            {
                "1" => new SuperSaiyan(),
                "2" => new SuperSaiyan2(),
                "3" => new SuperSaiyan3(),
                "4" => new SuperSaiyanGod(),
                "5" => new SuperSaiyanBlue(),
                "6" => new UltraInstinct(),
                "7" => new TrueUltraInstinct(),
                "8" => new GodOfDestructionForm(),
                "9" => new BeastForm(),
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

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nAvailable Special Attacks:");
            Console.ResetColor();
            Console.WriteLine("  1. Kamehameha       2. Final Flash");
            Console.WriteLine("  3. Spirit Bomb      4. Hakai");
            Console.WriteLine("  5. Justice Flash    6. Power Impact");
            Console.WriteLine("  7. Time Cage        8. Death Beam");
            Console.WriteLine("  9. Galick Gun      10. Destructo Disc");
            Console.Write("\nChoose the new move: ");

            var input = Console.ReadLine();
            IAttackStrategy attack = input switch
            {
                "1"  => new Kamehameha(),
                "2"  => new FinalFlash(),
                "3"  => new SpiritBomb(),
                "4"  => new Hakai(),
                "5"  => new JusticeFlash(),
                "6"  => new PowerImpact(),
                "7"  => new TimeCage(),
                "8"  => new DeathBeam(),
                "9"  => new GalickGun(),
                "10" => new DestructoDisc(),
                _    => null
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

        private static void PrintPowerBar(string name, int powerLevel)
        {
            int barLength = Math.Min(40, powerLevel / 250);
            string bar = new string('#', barLength) + new string('-', 40 - barLength);
            Console.ForegroundColor = powerLevel >= 8000 ? ConsoleColor.Red :
                                      powerLevel >= 5000 ? ConsoleColor.Yellow :
                                      ConsoleColor.Cyan;
            Console.WriteLine($"  {name,-15} [{bar}] {powerLevel}");
            Console.ResetColor();
        }

        private static void DisplayCharacterList()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < _characters.Count; i++)
                Console.WriteLine($"  {i + 1}. {_characters[i].Name}");
            Console.ResetColor();
        }

        private static int GetCharacterIndex(string prompt)
        {
            Console.Write($"\n{prompt} (1-{_characters.Count}): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > _characters.Count)
                Console.Write("Invalid selection. Try again: ");
            return choice - 1;
        }

        private static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress Enter to continue...");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
