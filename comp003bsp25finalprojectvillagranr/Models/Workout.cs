using System.ComponentModel.DataAnnotations;

namespace comp003bsp25finalprojectvillagranr.Models
{
    public class Workout
    {
        public int Id { get; set; } 

        [Required]
        public DateTime Date { get; set; }

        [Range(1, 500)]
        public int CaloriesBurned { get; set; }

      
        public User User { get; set; }
       
        public Exercise Exercise { get; set; }
    }
}
