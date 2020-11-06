using System;

namespace Events
{
    class MailServicess
    {
        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {
            Console.WriteLine($"{eventArgs.Video.Title} - sending an email ... ");
        }
    }
}
