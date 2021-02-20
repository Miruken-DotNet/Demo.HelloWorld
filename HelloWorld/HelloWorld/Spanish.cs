namespace HelloWorld
{
    public class Spanish : ILanguage
    {
        public string Translate(string phrase) => phrase switch
            {
                "Hello, World!"    => "Hola, Mundo!",
                "Nice to see you." => "Mucho gusto",
                "How are you?"     => "Como estas?",
                _                  => $"{phrase} ???"
            };
    }
} 