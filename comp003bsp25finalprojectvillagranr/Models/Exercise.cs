namespace comp003bsp25finalprojectvillagranr.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string MuscleGroup { get; set; }  
        public ICollection<Workout>? Workouts { get; set; }
    }
}
