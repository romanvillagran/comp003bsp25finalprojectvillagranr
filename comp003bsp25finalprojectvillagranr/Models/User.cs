using System.ComponentModel.DataAnnotations;

namespace comp003bsp25finalprojectvillagranr.Models
{
    public class User
    {
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
    }
}
