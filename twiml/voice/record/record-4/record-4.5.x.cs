using Twilio.TwiML;
using System;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        response.Record(transcribe: true,
            transcribeCallback: new Uri("/handle_transcribe.php"));

        System.Console.WriteLine(response);
    }
}
