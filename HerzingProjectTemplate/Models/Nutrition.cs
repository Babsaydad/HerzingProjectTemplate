using System.ComponentModel.DataAnnotations;

namespace HerzingProjectTemplate.Models
{
    public class Nutrition
    {
        public int ID { get; set; }
        public required string FoodName { get; set; }

        public decimal Calories { get; set; }

        public decimal Protein { get; set; }

        public decimal Fat { get; set; }

        public decimal Servings { get; set; }

        public decimal TotalRowCals { get; set; }

        public double BMR { get; set; }
        public double TDEE { get; set; }
        
        public required UserProfileInfo Profile { get; set; }
    }
}
