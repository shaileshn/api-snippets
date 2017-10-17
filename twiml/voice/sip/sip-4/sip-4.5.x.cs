using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Sip("sip:jack@example.com;transport=tcp");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
