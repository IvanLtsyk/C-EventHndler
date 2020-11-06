using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Test video" };
            var videoEncoder = new VideoEncoder();
            var mailServices = new MailServicess();
            var messageService = new MessageServicess();

            videoEncoder.VideoEncoded += mailServices.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
