using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial(record: "record-from-ringing");
        dial.Sim("DE8caa2afb9d5279926619c458dc7098a8");
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
