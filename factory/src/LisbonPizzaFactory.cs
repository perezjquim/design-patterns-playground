namespace factory
{
    class LisbonPizzaFactory : IPizzaFactory
    {
        public IPizza createPizza(string aType)
        {
            switch(aType)
            {
                case "cheese":
                    return new CheesePizza();
                default:
                    return new BlandPizza();
            }
        }
    }
}
