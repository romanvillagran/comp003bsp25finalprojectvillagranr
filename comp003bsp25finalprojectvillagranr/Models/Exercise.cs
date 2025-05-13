using System.ComponentModel.DataAnnotations;

namespace comp003bsp25finalprojectvillagranr.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }  
        public ICollection<Workout>? Workouts { get; set; }
    }
}
