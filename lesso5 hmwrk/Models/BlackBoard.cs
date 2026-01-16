using System.Data;

namespace lesso5_hmwrk.Models;

public class BlackBoard
{

    public Guid BBId { get; set; }
    public string SubjectBB {  get; set; }
    public string TopicBB { get; set; }
    public string TeacherName { get; set; }
    public DateTime CreatedDate { get; set; }

}
