using FitnessTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models
{
    public class Workout
    {
        public int Id { get; set; }   

        [Required]
        public string WorkoutName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string? Notes { get; set; }

        // One-to-many relationship
        public ICollection<Exercise>? Exercises { get; set; }
    }
}
