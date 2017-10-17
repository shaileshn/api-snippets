using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Client("jenny");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
