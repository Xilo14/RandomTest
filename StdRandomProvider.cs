namespace RandomTest
{
    public class StdRandomProvider : IRandomProvider
    {
        private double _chance = 0;
        private Random _rnd = new();
        public bool GetNextValue()
            => _rnd.NextDouble() > _chance;

        public void Reset()
        {
            
        }

        public void SetChance(double chance)
        {
            _chance = chance;
        }
    }
}