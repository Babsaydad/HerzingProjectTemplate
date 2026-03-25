using HerzingProjectTemplate.Services;

namespace HerzingProjectTemplate.Services
{
    public class HealthCalculatorService : IHealthCalculatorService
    {
        public double CalculateBmr(int age, double height, double weight, string gender)
        {
            if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else
            {
                return 10 * weight + 6.25 * height - 5 * age - 161;
            }
        }

        public double CalculateTdee(double bmr, double activityMultiplier)
        {
            return bmr * activityMultiplier;
        }
    }
}



