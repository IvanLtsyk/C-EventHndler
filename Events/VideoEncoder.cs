using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    class VideoEncoder
    {
        /*public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;*/

        public EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Video encoding ...");
            Thread.Sleep(3000);
            Console.WriteLine("Done");
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            /*if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }*/

            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });
        }
    }
}
