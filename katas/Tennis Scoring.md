Tennis Scoring Kata
============
Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

# Background #

In a game of tennis, a player begins with a score of zero (0). With each success, the player earns more points. The points are earned in this sequence:

- 0
- 15
- 30
- 40

If a player has 40 and scores again, that player wins the game as long as the other player does not also have 40 points. If both players reach 40 points it is referred to as a 'deuce.'

Scoring during deuce give a player advantage. If the other player scores again, the score returns to deuce. If a player has advantage and scores again, that player wins the game.

# Instructions #

Write a program to handle each of these requirements while scoring a two player game of tennis.

- Players must be able to score points
- The game must be able to be completed with a winner
- The 'deuce' case should be handled
- After a game has been won, a winner must be determined
- The current score of either player should be available at any point during the game

