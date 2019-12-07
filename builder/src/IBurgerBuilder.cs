namespace builder
{
    interface IBurgerBuilder
    {
        IBurgerBuilder AddBread();
        IBurgerBuilder AddLettuce();
        IBurgerBuilder AddOnions();
        IBurgerBuilder AddMeat();
        IBurgerBuilder AddCondiments();
    }
}