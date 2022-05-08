namespace RandomTest
{
    public class CustomRandomProvider : IRandomProvider
    {
        private double _chance = 0;
        private int _streak = 1;
        private Random _rnd = new();
        public bool GetNextValue()
        {
            var localChance = Math.Exp(_streak) / 3.0 * _chance * _chance;
            var res = _rnd.NextDouble() < localChance;

            if (res)
                _streak = 1;
            else
                _streak++;

            return res;
        }

        public void Reset()
        {
            _streak = 1;
        }

        public void SetChance(double chance)
        {
            _chance = chance;
        }
    }
}