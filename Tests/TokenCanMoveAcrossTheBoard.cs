using SnakesAndLadder;
using System;
using Xunit;

namespace Tests
{
    public class TokenCanMoveAcrossTheBoard
    {
        private readonly Game _game;

        public TokenCanMoveAcrossTheBoard()
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
            const int expectedPotions = 4;

            _game.MoveToken(spaces);

            Assert.True(_game.Position == expectedPotions, $"Token doesn't move {spaces} spaces");
        }

        [Fact]
        public void IsToken_MovedToPositionEight_When_MovingThreeAndThenFourSpacesFromSqaureOne()
        {
            const int firstSpaces = 3;
            const int secondSpaces = 4;
            const int expectedPotions = 8 ;

            _game.MoveToken(firstSpaces);
            _game.MoveToken(secondSpaces);

            Assert.True(_game.Position == expectedPotions, $"Token doesn't move incrementally to position {expectedPotions}");
        }
    }
}
