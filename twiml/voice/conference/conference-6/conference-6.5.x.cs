using Twilio.TwiML;
using System;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Conference("NoMusicNoBeepRoom", beep: "false",
            waitUrl: new Uri("http://your-webhook-host.com"),
            startConferenceOnEnter: true, endConferenceOnExit: true);
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
