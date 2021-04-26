namespace Solid.Printer
{
    internal interface IPrinter
    {
        string Print(string content, int numberOfCopies = 2);
        void PrintAndSendNotification(string content, NotificationType notificationType);
    }
}
