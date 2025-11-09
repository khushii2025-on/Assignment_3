using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        [Required]
        public string ExerciseName { get; set; }

        public int Reps { get; set; }

        public int Sets { get; set; }

        public double Weight { get; set; }

        // Foreign Key
        [Display(Name = "Workout")]
        public int WorkoutId { get; set; }

        [ForeignKey("WorkoutId")]
        public Workout? Workout { get; set; }
    }
}

