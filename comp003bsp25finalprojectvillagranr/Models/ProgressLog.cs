namespace comp003bsp25finalprojectvillagranr.Models
{
    public class ProgressLog
    {
        public int Id { get; set; } 

        public DateTime LogDate { get; set; }
        public double Weight { get; set; }

        public User User { get; set; }
    }
}
