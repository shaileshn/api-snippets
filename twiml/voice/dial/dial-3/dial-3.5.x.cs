using Twilio.TwiML;
using Twilio.Http;
using System;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        response.Dial("415-123-4567", action: new Uri("/handleDialCallStatus.php"),
            method: HttpMethod.Get);
        response.Say("I am unreachable");

        System.Console.WriteLine(response);
    }
}
