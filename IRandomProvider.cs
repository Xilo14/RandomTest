namespace RandomTest
{
	public interface IRandomProvider
	{
        void SetChance(double chance);
        bool GetNextValue();
        void Reset();
	}
}