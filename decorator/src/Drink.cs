namespace decorator
{
    abstract class Drink
    {
        public Drink mContent { get; }

        public Drink(Drink aDrink = null)
        {
            mContent = aDrink;
        }

        public abstract void Make();

        public void Finish()
        {
            if (mContent != null)
            {
                mContent.Finish();
            }
            Make();
        }
    }
}