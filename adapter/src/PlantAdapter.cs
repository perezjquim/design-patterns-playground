namespace adapter
{
    class PlantAdapter : IAnimal
    {
        public Plant mPlant { get; set; }

        public PlantAdapter(Plant aPlant)
        {
            mPlant = aPlant;
        }

        public void Eat()
        {
            mPlant.EarnEnergy();
        }
    }
}