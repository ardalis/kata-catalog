Hangman Kata
================

Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

## Background

Hangman is a well-known word guessing game in which a secret word is shown as hidden letters, and the player guesses letters. Correct guesses unmask letters in their appropriate position of the secret word. Incorrect guesses are counted against the player. If the number of incorrect guesses exceeds the limit before the word is correctly revealed, the player loses. If they can reveal the entire word before running out of incorrect guesses, they win!

This kata is designed to help with test-first coding and refactoring and design. You can stick to just writing the library code, or produce a working version of the game using a UI of your choice (e.g. console, WinForms, WPF, web, etc.).

## Instructions

1. Create a class `Hangman` to represent the game.
   1. When created, the class should accept a secret word and store it in ALLCAPS.
   2. When created, the class should store the number of incorrect guesses that will result in losing the game.
   3. When created, the class should expose a property indicating that the game is in progress.
2. Add a Guess method to the class which returns a result.
   1. A guess should accept a letter.
   2. If the letter isn't a valid character ("A-Z" or whatever you want to define valid to be), return an invalid guess result.
   3. If the letter isn't in the word, return an incorrect guess result and add the letter to a list of incorrect guesses.
   4. If the letter was previously guessed (correctly or not), return a duplicate guess result.
3. After each guess, calculate the new game state.
   1. If all letters have been guessed, the game is won.
   2. If total incorrect guess count equals the number set when the game was created, the game is lost.
   3. Otherwise, the game is in progress.

You're free to design the class(es) however you want. In the References below you'll find two approval tests you can use that rely on your design outputting the results and game state as strings.

## User Interface / Game Client

If you build a UI for the game, it should have the following features:

- Display the masked secret word at game start and after each guess. Display correctly guessed letters in the proper position in the word.
- Display a list of incorrectly guessed letters.
- If the letter is in the word, unmask all instances of the letter in the word.
- Display how many guesses the player has left. This should be positive unless the game was just lost.
- If the game is won, display a message announcing this.
- If the game is lost, display a message announcing this.
- Accept a new guess from the player while the game is in progress.

## References

- Thanks [happybits](https://github.com/happy-bits) for the idea for this kata!
- [Example Approval Tests](../src/hangman/ApprovalTests.cs) Two approval tests that can be used to validate your implementation of the game engine.
