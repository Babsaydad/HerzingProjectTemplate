using System.ComponentModel.DataAnnotations;

namespace HerzingProjectTemplate.Models
{
    public class UserProfileInfo
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        
        [Range(1, 500)]
        public required double Weight { get; set; }

        
        [Range(30, 300)]
        public required double Height { get; set; }

        public required int Age { get; set; }

        public required string Gender { get; set; }

        
        public required string ExerciseMode { get; set; } 
    }
       
}



