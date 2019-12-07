namespace builder
{
    class BKBuilder : IBurgerBuilder
    {
        private Burger mBurger;

        public BKBuilder()
        {
            mBurger = new Burger();
        }

        public IBurgerBuilder AddBread()
        {
            mBurger.AddIngredient("carcaça");
            
            return this;
        }
        public IBurgerBuilder AddLettuce()
        {
            mBurger.AddIngredient("alface roxa");

            return this;
        }
        public IBurgerBuilder AddOnions()
        {
            mBurger.AddIngredient("cebola caramelizada");

            return this;
        }
        public IBurgerBuilder AddMeat()
        {
            mBurger.AddIngredient("carne de frango");

            return this;
        }
        public IBurgerBuilder AddCondiments()
        {
            mBurger.AddIngredient("ketchup");

            return this;
        }

        public Burger Build()
        {
            return mBurger;
        }
    }
}