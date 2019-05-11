using SnakesAndLadder;
using System;
using Xunit;

namespace Tests
{
    public class TokenCanMoveAcrossBoard
    {
        private readonly Game _game;

        public TokenCanMoveAcrossBoard()
        {
            _game = new Game();
        }

        [Fact]
        public void IsToken_OnSquareOne_When_GameIsStarted()
        {
            Assert.True(_game.Position == 1, "Games doesn't start on square 1");
        }

        [Fact]
        public void IsToken_MovedToPositionFour_When_MovingThreeSpacesFromSqaureOne()
        {
            const int spaces = 3;

            _game.MoveToken(spaces);

            Assert.True(_game.Position == 4, $"Token doesn't move {spaces}");
        }

        [Fact]
        public void IsToken_MovedToPositionEight_When_MovingThreeAndThenFourSpacesFromSqaureOne()
        {
            const int firstSpaces = 3;
            const int secondSpaces = 3;

            _game.MoveToken(firstSpaces);
            _game.MoveToken(secondSpaces);

            Assert.True(_game.Position == 8, $"Token doesn't move incrementally to position {firstSpaces + secondSpaces}");
        }
    }
}
