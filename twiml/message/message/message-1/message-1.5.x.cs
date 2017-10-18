using Twilio.TwiML;


class Example
{
    static void Main()
    {
        var response = new MessagingResponse();
        response.Append(new Message("Store Location: 123 Easy St."));

        System.Console.WriteLine(response);
    }
}
