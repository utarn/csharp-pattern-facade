using System;

namespace pattern_facade
{
    class Program
    {
        static void Main(string[] args)
        {
           var notificationService = new NotificationService();
           notificationService.Send("hello", "target");           
        }
    }
}
