using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal c = new Carnivore();
            c.Eat();

            IAnimal h = new Herbivore();
            h.Eat();

            IAnimal o = new Omnivore();
            o.Eat();

            Plant p = new Plant();
            PlantAdapter pa = new PlantAdapter(p);

            pa.Eat();
        }
    }
}
