namespace DemoLibrary
{
    public interface IMessageSender
    {
        void sendEmail(IPerson person, string message);
    }
}