using System.ComponentModel.DataAnnotations;

namespace HerzingProjectTemplate.Models
{
    public class UserProfileInfo
    {
        public required int UserId { get; set; } 
        public required string FirstName { get; set; } 

        public required string LastName { get; set; } 

        
        [Range(1, 500)]
        public double Weight { get; set; }

        
        [Range(30, 300)]
        public double Height { get; set; }

        public int Age { get; set; }

        public required string Gender { get; set; } 

        
        public required string ExerciseMode { get; set; } 
        
        public required string ActivityLevel { get; set; } 

        public required string Goal { get; set; }

        public double BMR { get; set; }

        public double TDEE { get; set; }
    }
       
}



