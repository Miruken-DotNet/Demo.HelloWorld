namespace HelloWorld
{
    using System;
    using System.Threading.Tasks;
    using Miruken.Api;
    using Miruken.Callback;

    public class SpeechHandler
    {
        [Handles]
        public async Task<SpeechResult> SayHello(SayHello sayHello, [Optional] ILanguage language, IHandler composer)
        {
            const string phrase = "Hello, World!";
            var speech = language?.Translate(phrase) ?? phrase;
            //var pleasantry = await composer.Send(new ExchangePleasantry());
            
            //return new SpeechResult($"{speech}{Environment.NewLine}{pleasantry.Speech}");
            return new SpeechResult(speech);
        }
        
        // [Handles]
        // public SpeechResult ExchangePleasantry(ExchangePleasantry exchangePleasantry, [Optional] ILanguage language)
        // {
        //     var random = _random.Next(0, Pleasantries.Length);
        //     var phrase = Pleasantries[random];
        //     return new SpeechResult(language?.Translate(phrase) ?? phrase);
        // }

        private readonly Random _random = new();
        private static readonly string[] Pleasantries =
        {
            "Nice to see you.",
            "How are you?"
        };
    }
}