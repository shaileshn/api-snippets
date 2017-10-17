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
        dial.Number("+14155555555",
            statusCallbackEvent: "initiated ringing answered completed",
            statusCallback: new Uri("https://myapp.com/calls/events"),
            statusCallbackMethod: HttpMethod.Post);
        dial.Number("+14153333333",
            statusCallbackEvent: "initiated ringing answered completed",
            statusCallback: new Uri("https://example.com/events"),
            statusCallbackMethod: HttpMethod.Post);
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
