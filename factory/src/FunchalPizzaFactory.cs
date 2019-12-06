namespace factory
{
    class FunchalPizzaFactory : IPizzaFactory
    {
        public IPizza createPizza(string aType)
        {
            switch(aType)
            {
                case "cheese":
                    return new CheesePizza();
                case "greek":
                    return new GreekPizza();
                default:
                    return new BlandPizza();
            }
        }
    }
}
