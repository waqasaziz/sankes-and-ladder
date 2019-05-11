using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace SnakesAndLadder
{
    public class Game
    {
        private const int MaxTokenPosition = 100;

        private readonly IDiceRoller _diceRoller;
        public int Position { get; private set; }

        public Game(int statrPosition = 1) : this(new DefaultDiceRoller())
        {
            Position = statrPosition;
        }

        public Game(IDiceRoller diceRoller, int statrPosition = 1)
        {
            _diceRoller = diceRoller ?? throw new ArgumentException(nameof(diceRoller));
            Position = statrPosition;
        }

        public void MoveToken(int spaces)
        {

            if (Position + spaces <= MaxTokenPosition)
                Position += spaces;
        }

        public void RolleDice() => MoveToken(_diceRoller.Roll());

    }
}
