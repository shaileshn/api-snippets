using Twilio.TwiML;
using Twilio.TwiML.Voice;
using Twilio.Http;
using System;


class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var dial = new Dial(record: "record-from-answer", timeout: 10,
            hangupOnStar: true, callerId: "bob", method: HttpMethod.Post,
            action: new Uri("/handle_post_dial"));
        dial.Sip("sip:kate@example.com?customheader=foo", method: HttpMethod.Post,
            url: new Uri("/handle_screening_on_answer"));
        response.Append(dial);

        System.Console.WriteLine(response);
    }
}
