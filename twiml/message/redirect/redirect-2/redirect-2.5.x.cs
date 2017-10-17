using Twilio.TwiML;
using System;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        response.Redirect(new Uri("../nextInstructions"));

        System.Console.WriteLine(response);
    }
}
