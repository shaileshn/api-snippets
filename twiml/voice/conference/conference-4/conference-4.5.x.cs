using Twilio.TwiML;
using Twilio.TwiML.Voice;
using System;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Conference("EventedConf",
            statusCallback: new Uri("https://myapp.com/events"),
            statusCallbackEvent: "start end join leave mute hold");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
