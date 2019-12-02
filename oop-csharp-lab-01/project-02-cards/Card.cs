namespace Cards
{
    class Card
    {
        private readonly string seed;
        private readonly string value;

        public Card(string value, string seed)
        {
            this.value = value;
            this.seed = seed;
        }

        public string GetSeed()
        {
            return this.seed;
        }

        public string GetValue()
        {
            return this.value;
        }

        public override string ToString()
        {
            // TODO comprendere il meccanismo denominato in C# "string interpolation"
            return $"{this.GetType().Name}(Name={this.GetValue()}, Seed={this.GetSeed()})";
        }
    }

    
}
