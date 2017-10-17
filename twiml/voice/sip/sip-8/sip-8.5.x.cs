using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Sip("sip:kate@example.com?mycustomheader=foo&myotherheader=bar");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
