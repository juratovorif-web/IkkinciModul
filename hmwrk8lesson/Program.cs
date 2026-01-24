using hmwrk8lesson.Services;

namespace hmwrk8lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Inotification notification = GetInotification();
            notification.InotificationMoney();
        }
        
        public static Inotification GetInotification()
        {
            //Inotification inotification = new ClickService();
            //Inotification inotification = new PayMeService();
            Inotification inotification = new PayNetService();
            return inotification;
            

        }
    }
}
