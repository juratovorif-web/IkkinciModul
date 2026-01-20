namespace lesson_6.Models;

public class Singer
{
    public Guid SingerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SingerName { get; set; }
    public string Password { get; set; }
    public List<string> MusicName { get; set; }
    public List<string> Genres { get; set; }
    public List<string> Awards { get; set; }
    public int TotalPlays { get; set; }
    
}
