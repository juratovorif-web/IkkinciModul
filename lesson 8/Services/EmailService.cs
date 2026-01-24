namespace lesson_8.Services;

public class EmailService : INotification
{
    public void SendNotification()
    {
        Console.WriteLine("Hamma xodimlarga emaildan notification ketdi");
    }
}
