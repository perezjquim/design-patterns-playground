namespace builder
{
    class MCBuilder : IBurgerBuilder
    {
        private Burger mBurger;

        public MCBuilder()
        {
            mBurger = new Burger();
        }

        public IBurgerBuilder AddBread()
        {
            mBurger.AddIngredient("bolo do caco");

            return this;
        }
        public IBurgerBuilder AddLettuce()
        {
            mBurger.AddIngredient("alface");

            return this;
        }
        public IBurgerBuilder AddOnions()
        {
            mBurger.AddIngredient("anéis de cebola");

            return this;
        }
        public IBurgerBuilder AddMeat()
        {
            mBurger.AddIngredient("carne de vaca");

            return this;
        }
        public IBurgerBuilder AddCondiments()
        {
            mBurger
                .AddIngredient("maionese")
                .AddIngredient("mostarda");

            return this;
        }

        public Burger Build()
        {
            return mBurger;
        }
    }
}