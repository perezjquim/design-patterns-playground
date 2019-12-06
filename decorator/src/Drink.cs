namespace decorator
{
    abstract class Drink
    {
        public Drink mContent { get; set; }

        public Drink()
        { }

        public Drink(Drink aDrink)
        {
            mContent = aDrink;
        }

        public abstract void Make();

        public void Finish()
        {
            if(mContent != null )
            {
                mContent.Finish();
            }
            Make();
        }
    }
}