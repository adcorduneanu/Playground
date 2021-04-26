namespace Solid.Printer
{
    public class Configuration
    {
        public Email Email { get; }

        public Sms Sms { get; }
    }

    public class Sms
    {
        public string ApiKey = "Api-Key";
        public string Destination = "123456778";
        public string Source = "Me";
    }

    public class Email
    {
        public string MainEmail = "Email";
        public string MainPassword = "Password";
        public int Port = 587;
    }
}
