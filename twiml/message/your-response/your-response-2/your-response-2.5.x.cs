using Twilio.TwiML;


class Example
{
    static void Main()
    {
        var response = new MessagingResponse();
        response.Append(new Message("This is message 1 of 2."));
        response.Append(new Message("This is message 2 of 2.");)

        System.Console.WriteLine(response);
    }
}
