namespace HerzingProjectTemplate.Services
{
    public interface IHealthCalculatorService
    {
        double CalculateBmr(int age, double height, double weight, string gender);
        double CalculateTdee(double bmr, double activityMultiplier);
    }
}
