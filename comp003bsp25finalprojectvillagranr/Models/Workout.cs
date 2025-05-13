using System.ComponentModel.DataAnnotations;

namespace comp003bsp25finalprojectvillagranr.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Workout name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Range(1, 500, ErrorMessage = "Calories must be 1-500")]
        public int CaloriesBurned { get; set; }

        public int ExerciseId { get; set; }
        public Exercise? Exercise { get; set; }
    }
}
