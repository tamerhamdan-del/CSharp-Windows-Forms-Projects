# 🎮 Tic-Tac-Toe (XO) Game

A simple **Tic-Tac-Toe (XO)** desktop game developed using **C#** and **Windows Forms**.

This project was built to practice event-driven programming, Windows Forms controls, and game logic implementation.

---

## Features

- ✅ Two-player gameplay
- ✅ Turn indicator
- ✅ Win detection
  - Rows
  - Columns
  - Diagonals
- ✅ Draw detection
- ✅ Restart game functionality
- ✅ Winning cells are highlighted
- ✅ Prevents playing after the game is over
- ✅ Prevents selecting an occupied cell

---

## Technologies Used

- C#
- .NET Framework
- Windows Forms
- Visual Studio

---

## Game Preview

![Project Screenshot](Screenshot%202026-07-14%20111445.png)


## Project Structure

```
XO Game
│
├── Form1.cs
├── Form1.Designer.cs
├── Resources
├── Properties
└── Program.cs
```

---

## Game Logic

The game uses:

- Enums to represent:
  - Current Player
  - Game Winner
- Struct to store the game status:
  - Winner
  - Game Over
  - Play Count
- Methods for:
  - Switching turns
  - Checking winners
  - Restarting the game
  - Updating the UI

---

## How to Play

1. Player 1 starts with **X**.
2. Player 2 plays **O**.
3. Players take turns selecting empty cells.
4. The first player to complete a row, column, or diagonal wins.
5. If all cells are filled without a winner, the game ends in a draw.

---

## Learning Objectives

This project helped me practice:

- Windows Forms development
- Event handling
- Game state management
- Enums and Structs
- Method organization
- Conditional logic
- Resource management
- Desktop application development

---

## Future Improvements

- 🤖 Single-player mode (AI)
- 🎵 Sound effects
- ⏱️ Game timer
- 📊 Scoreboard
- 🎨 Better UI design
- 💾 Save game history

---

## Author

**Tamer Hamdan**

GitHub:
https://github.com/tamerhamdan-del

---

⭐ If you like this project, feel free to star the repository.
