using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Sip("kate@example.com");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
