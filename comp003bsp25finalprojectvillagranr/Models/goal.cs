namespace comp003bsp25finalprojectvillagranr.Models
{
    public class goal
    {
        public int Id { get; set; } 

        public string Title { get; set; }
        public DateTime TargetDate { get; set; }

        public User User { get; set; }
    }
}
