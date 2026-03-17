using System.ComponentModel.DataAnnotations;

namespace HerzingProjectTemplate.Models
{
    public class Workout
    {

        public required string SelectedWorkoutType { get; set; } = string.Empty;

        public required List<string> SelectedExercises { get; set; } = new List<string>();
    }
}
