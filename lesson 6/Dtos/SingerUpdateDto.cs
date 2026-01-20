namespace lesson_6.Dtos;

public class SingerUpdateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SingerName { get; set; }
    public string Password { get; set; }
    public List<string> MusicName { get; set; }
    public List<string> Genres { get; set; }
    public List<string> Awards { get; set; }
}
