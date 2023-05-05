
namespace Basebal
{
    internal class RetiredPlayer
    {
        public string Name {  get; private set; }
        public int YearRetired { get; private set; }

        public RetiredPlayer(string player, int yearRetired)
        {
            Name = player;
            YearRetired = yearRetired;
        }

        public override string ToString()
        {
            return $"{Name} retired in {YearRetired}";
        }
    }
}
