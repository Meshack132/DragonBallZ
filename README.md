

---

```markdown
# 🐉 Dragon Ball Z: Tournament of Power — SOLID Console App

An interactive, **Dragon Ball Z–themed C# console application** built using SOLID principles and structural design patterns. Step into the arena of the Tournament of Power, manage transformations, teach new attacks, and simulate epic battles between your favorite characters — all while mastering clean code architecture.

---

## 🎮 Features

- 🔁 **Strategy Pattern** for dynamic attack switching  
- 💥 **Transformations** with power multipliers  
- 🧠 **SOLID Principles** applied throughout the architecture  
- ⚔️ **Battle Simulation** with real-time power comparisons  
- 🧩 **Modular Design** using Interfaces and Factory Pattern  
- 💻 100% **Console-Based**, no external dependencies

---

## 🧱 Tech Stack

- Language: **C# (.NET Core)**  
- Architecture: **SOLID, OOP, Strategy Pattern, Factory Pattern**  
- UI: **Console Application**

---

## 🧠 SOLID Principles in Action

| Principle | Implementation |
|----------|----------------|
| SRP (Single Responsibility) | Separate classes for character logic, transformation, attack, and creation |
| OCP (Open/Closed) | Add new forms or attacks without touching core logic |
| LSP (Liskov Substitution) | All transformations/attacks interchangeable via interfaces |
| ISP (Interface Segregation) | Modular contracts for transformation and combat behavior |
| DIP (Dependency Inversion) | Characters depend on abstractions like `IAttackStrategy`, not concrete classes |

---

## 📁 Folder Structure

```

DragonBallZ/
├── App/                # Main Program.cs (console interactions)
├── Core/
│   ├── Factory/        # CharacterCreator
│   ├── Interfaces/     # ICharacter, IAttackStrategy, ITransformation
│   └── Models/         # BaseCharacter
├── Attacks/            # Concrete attack strategies
├── Transformations/    # Character transformation classes
└── README.md

````

---

## 🛠️ Getting Started

1. **Clone the repository**

```bash
git clone https://github.com/your-username/DragonBallZ-SOLID-App.git
cd DragonBallZ-SOLID-App
````

2. **Run the app**

Open the project in **Visual Studio** or run from terminal:

```bash
dotnet run --project DragonBallZ.App
```

3. **Enjoy!**

Explore character rosters, simulate battles, apply new transformations and attacks. Customize and extend at will.

---

## 💡 Sample Console Output

```
=== DRAGON BALL Z SUPER SYSTEM ===
1. View Characters
2. Simulate Battle
3. Transform Character
4. Teach New Attack
5. Exit

Goku transforms into Ultra Instinct!
Goku prepares to attack...
KA-ME-HA-ME-HAAAA!!

Jiren responds with Power Impact!
🔥 Winner: Goku!
```

---

## 👨‍💻 Author

**Meshack Mthimkhulu**
Software Engineer | C# Developer | Clean Architecture Advocate
GitHub: [@Meshack132](https://github.com/Meshack132)

---

## 🌟 Future Ideas

* Add power progression / leveling
* Store character stats in JSON
* Introduce combo attacks / tag-team fights
* Integrate with audio effects via .wav
* Migrate to a WPF GUI version

---

## 🧪 Want to Practice SOLID?

This repo is an excellent base to:

* Refactor
* Add new characters (e.g., Gohan, Android 17, Kefla)
* Introduce unit tests for transformations and attacks

---

## 📜 License

MIT License — use it freely, but credit when inspired.

---

> “The power comes in response to a need, not a desire. You have to create that need.”
> — Goku

```

