using SnakesAndLadder;
using System;
using Xunit;

namespace Tests
{
    public class PlayerCanWinTheGame
    {
        private readonly Game _game;

        public PlayerCanWinTheGame()
        {
            _game = new Game(97);
        }

        [Fact]
        public void HasWon_When_TokenIsMovedThreeSpaces_FromPositionNintySeven()
        {
            _game.MoveToken(3);

            Assert.True(_game.IsWon, "User doesn't win the game");
        }

        [Fact]
        public void HasNotWon_When_TokenIsMovedFourSpaces_FromPositionNintySeven()
        {
            _game.MoveToken(4);

            Assert.False(_game.IsWon, "User wins the game when he shouldn't");
        }

        [Fact]
        public void IsRoll_Invalid_When_TokenPositionExceeds_Hundred()
        {
            _game.MoveToken(4);

            Assert.True(_game.Position == 97, "Roll wasn't declared invalid");
        }
    }
}
