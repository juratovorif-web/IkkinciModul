using lesson_8.Services;
using Microsoft.Win32.SafeHandles;

namespace lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotification notification = GetNtification();
            notification.SendNotification();   
        }
        public static INotification GetNtification()
        {
            //INotification Notification = new EmailService();
            INotification Notification = new AccauntService();
            //INotification Notification = new TeamsService();
            return Notification;
        }
    }
}
