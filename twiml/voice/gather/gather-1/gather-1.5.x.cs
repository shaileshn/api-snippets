using Twilio.TwiML;
using Twilio.TwiML.Voice;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var gather = new Gather(input: "speech dtmf", timeout: 3, numDigits: 1);
        gather.Say("Please press 1 or say sales for sales.");
        response.Append(gather);

        System.Console.WriteLine(response);
    }
}
