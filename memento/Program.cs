using System;

namespace memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.Play();

            GameState gs = g.Save();

            g.Play();
            g.Play();
            g.Play();
            g.Play();

            g.Restore(gs.mState);
            
            g.Play();
            g.Play();
        }
    }
}
