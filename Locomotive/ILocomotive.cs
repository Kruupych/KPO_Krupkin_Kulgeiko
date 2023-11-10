namespace Locomotive
{
    public interface ILocomotive
    {
        double Length { get; }
        double Power { get; }
        double Weight { get; }
        bool IsElectric { get; }
        public double CalculateMaxSpeed(double totalWeight);
    }
}