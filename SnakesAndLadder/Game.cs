namespace SnakesAndLadder
{
    public class Game
    {
        private const int MaxTokenPosition = 100;

        public int Position { get; private set; }

        public Game(int statrPosition = 1)
        {
            Position = statrPosition;
        }

        public void MoveToken(int spaces)
        {

            if (Position + spaces <= MaxTokenPosition)
                Position += spaces;
        }
    }
}
