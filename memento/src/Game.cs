using System;

namespace memento
{
    class Game
    {
        public string mState { get; private set; }

        public Game()
        {
            mState = "";
        }

        public void Play()
        {
            mState += " stuff ";
            Console.WriteLine($"Current state: {mState}");
        }

        public GameState Save()
        {
            Console.WriteLine("state saved!");
            return new GameState(mState);
        }

        public void Restore(string aState)
        {
            mState = aState;
            Console.WriteLine("state restored!");
        }
    }
}