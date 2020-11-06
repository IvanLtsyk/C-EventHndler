using System;

namespace Events
{
    class MessageServicess
    {
        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {
            Console.WriteLine($"{eventArgs.Video.Title} - sending text message ... ");
        }
    }
}
