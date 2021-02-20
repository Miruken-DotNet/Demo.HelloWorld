namespace HelloWorld
{
    using System;
    using Miruken.Callback;

    public class SpeechHandler
    {
        [Handles]
        public void SayHello(SayHello message)
        {
            Console.WriteLine("Hello, World!");  
        }
    }
}