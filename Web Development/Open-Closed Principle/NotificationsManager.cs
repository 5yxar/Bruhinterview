namespace Open_Closed_Principle_Practice
{
    public class NotificationsManager
    {
        private readonly ISender _sender;

        public NotificationsManager(ISender sender)
        {
            _sender = sender;
        }
        
        public void Send(string message)
        {
            _sender.Send(message);
        }
    }
}