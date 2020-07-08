using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hangman.Core.Test
{
    [TestClass]
    public class ApprovalTests
    {

        [TestMethod]
        public void game_should_be_lost()
        {
            var game = new Hangman("BELL", 3);

            Assert.AreEqual("Status:GameIsOn;Word:----;Guesses:;Guesses left:3", game.ToString());

            var result = game.Guess("X");
            Assert.AreEqual("IncorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:----;Guesses:X;Guesses left:2", game.ToString());

            result = game.Guess("#");
            Assert.AreEqual("InvalidGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:----;Guesses:X;Guesses left:2", game.ToString());

            result = game.Guess("BB");
            Assert.AreEqual("InvalidGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:----;Guesses:X;Guesses left:2", game.ToString());

            result = game.Guess("L");
            Assert.AreEqual("CorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:--LL;Guesses:X L;Guesses left:2", game.ToString());

            result = game.Guess("Y");
            Assert.AreEqual("IncorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:--LL;Guesses:X L Y;Guesses left:1", game.ToString());

            result = game.Guess("Z");
            Assert.AreEqual("IncorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameLost;Word:--LL;Guesses:X L Y Z;Guesses left:0", game.ToString());

            Assert.ThrowsException<InvalidOperationException>(() => game.Guess("B"));

        }

        [TestMethod]
        public void game_should_be_won()
        {
            var game = new Hangman("BELL", 3);

            Assert.AreEqual("Status:GameIsOn;Word:----;Guesses:;Guesses left:3", game.ToString());

            var result = game.Guess("X");
            Assert.AreEqual("IncorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:----;Guesses:X;Guesses left:2", game.ToString());

            result = game.Guess("#");
            Assert.AreEqual("InvalidGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:----;Guesses:X;Guesses left:2", game.ToString());

            result = game.Guess("BB");
            Assert.AreEqual("InvalidGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:----;Guesses:X;Guesses left:2", game.ToString());

            result = game.Guess("L");
            Assert.AreEqual("CorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:--LL;Guesses:X L;Guesses left:2", game.ToString());

            result = game.Guess("Y");
            Assert.AreEqual("IncorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:--LL;Guesses:X L Y;Guesses left:1", game.ToString());

            result = game.Guess("B");
            Assert.AreEqual("CorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameIsOn;Word:B-LL;Guesses:X L Y B;Guesses left:1", game.ToString());

            result = game.Guess("E");
            Assert.AreEqual("CorrectGuess", result.ToString());
            Assert.AreEqual("Status:GameWon;Word:BELL;Guesses:X L Y B E;Guesses left:1", game.ToString());

            Assert.ThrowsException<InvalidOperationException>(() => game.Guess("B"));
        }
    }
}