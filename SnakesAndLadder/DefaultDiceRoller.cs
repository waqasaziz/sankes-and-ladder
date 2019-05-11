using System;

namespace SnakesAndLadder
{
    internal sealed class DefaultDiceRoller : IDiceRoller
    {
        public int Roll() => new Random().Next(1, 6);
    }
}
