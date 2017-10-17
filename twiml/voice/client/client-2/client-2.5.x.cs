using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial(callerId: "+1888XXXXXXX");
        dial.Number("858-987-6543");
        dial.Client("jenny");
        dial.Client("tommy");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
