namespace Open_Closed_Principle_Practice
{
    public class EmailNotificationsManager : INotificationsManager
    { 
        public void Send(string message)
        {
            // Код для отправки E-mail уведомления.
        }
    }

    public class SmsNotificationsManager : INotificationsManager
    {
        public void Send(string message)
        {
            // Код для отправки СМС уведомления
        }
    }
}