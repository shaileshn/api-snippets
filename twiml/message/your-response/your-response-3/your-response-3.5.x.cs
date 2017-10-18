using Twilio.TwiML;


class Example
{
    static void Main()
    {
        var response = new MessagingResponse();
        response.Append(new Message("I'm hungry!"));

        System.Console.WriteLine(response);
    }
}
