using Twilio.TwiML;
using Twilio.Http;
using System;


class Example
{
    static void Main()
    {
        var response = new MessagingResponse();
        var message = new Message("Store Location: 123 Easy St.",
            action: new Uri("/SmsHandler.php"), method: HttpMethod.Post);
        response.Append(message);

        System.Console.WriteLine(response);
    }
}
