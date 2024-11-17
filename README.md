# Low-Level Design - UML Diagram

![image](https://github.com/user-attachments/assets/d64751ab-9e5e-49c3-9549-0e343bed4b08)


# Tic Tac Toe Game

Tic Tac Toe is a classic two-player game implemented in C# for console. The game is played on a 3x3 grid, where each player alternates turns to place their mark—**'X'** or **'O'**—with the goal of getting three in a row, column, or diagonal.

## How to Play

1. **Game Setup**: The game starts with an empty 3x3 board represented by `'-'` in each cell.
2. **Player Turns**: 
   - Player 1 and Player 2 take turns to mark an available cell with their symbol (`'X'` or `'O'`).
   - Players are prompted to enter the row and column coordinates (0, 1, or 2) for their move.
3. **Winning Condition**: After each move, the board checks if the player has achieved three symbols in a row, column, or diagonal. If so, that player wins.
4. **Tie Condition**: If all cells are filled and no winning line is achieved, the game results in a tie.
5. **Restart Option**: After a win or tie, the board can be reset to play again.

## Game Structure

This project is structured with separate classes for better modularity:

- **Board**: Manages the game board, including cell placements and win/tie checks.
- **Player**: Represents each player, with attributes for their name and symbol (`'X'` or `'O'`).
- **Game**: Manages the flow, alternating turns, and checking win conditions.
- **Program**: The main entry point to initialize players and start the game.

## Example Gameplay

```plaintext
Welcome to Tic Tac Toe!
- - -
- - -
- - -

Player 1's turn (X). Enter row and column (0, 1, or 2):
X - -
- - -
- - -

and so on...

The game continues until there is a winner or a tie, and the board state is displayed after each move. This game emphasizes strategic planning and attention to opponent moves. It’s a simple, fun, and engaging game for players of all ages.

## Enjoy the game, and good luck!!
