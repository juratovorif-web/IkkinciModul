using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson_3.Models;

public class Earth
{
    public Guid EarthId { get; set; }
    public string Countries { get; set; }
    public double Volume { get; set; }
    public int Population { get; set; }
    public bool IsDeveloped { get; set; }
}
