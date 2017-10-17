using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial(callerId: "+15551112222");
        dial.Number("+15558675309");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
