namespace prototype
{
    class Animal
    {
        public int mAge { get; set; }
        public string mRace { get; set; }
        public string mName { get; set; }
        public string mDesc { get; }
        public Animal(int aAge, string aRace, string aName)
        {
            mAge = aAge;
            mRace = aRace;
            mName = aName;
            mDesc = $"{mName} ({mRace})";
        }

        public Animal Clone()
        {
            return (Animal) this.MemberwiseClone();
        }
    }
}