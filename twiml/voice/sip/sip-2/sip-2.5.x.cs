using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial();
        dial.Sip("sip:kate@example.com", username: "admin", password: "1234");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
