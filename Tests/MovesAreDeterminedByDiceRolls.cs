using Moq;
using SnakesAndLadder;
using Xunit;

namespace Tests
{
    public class MovesAreDeterminedByDiceRolls
    {

        [Fact]
        public void DiceRoller_ShouldAlways_Roll_BetweenOneAndSix()
        {
            var diceRoller = new DefaultDiceRoller();
            var result = diceRoller.Roll();
            Assert.True(result >= 1 && result <= 6, "Dice roller rolled Out of 1-6 incluive range");
        }

        [Fact]
        public void IsToken_MovedToPositionFour_When_RolledFour()
        {
            const int requiredRollValue = 4;

            var roller = new Mock<IDiceRoller>();
            roller.Setup(rdr => rdr.Roll()).Returns(requiredRollValue);

            var game = new Game(roller.Object);
            game.RolleDice();

            Assert.True(game.Position == 5, $"Token doesn't move to position {requiredRollValue}");
        }

        [Fact]
        public void Is_DiceRoller_Called()
        {
            var rollerStub = new Mock<IDiceRoller>();
            var game = new Game(rollerStub.Object);
            game.RolleDice();

            rollerStub.Verify(rdr => rdr.Roll(), "Roll() isn't called.");
        }
    }
}
