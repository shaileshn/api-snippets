using Twilio.TwiML;
using Twilio.TwiML.Voice;
using Twilio.Http;
using System;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Client("jenny",
            statusCallbackEvent: "initiated ringing answered completed",
            statusCallback: new Uri("https://myapp.com/calls/events"),
            statusCallbackMethod: HttpMethod.Post);
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
