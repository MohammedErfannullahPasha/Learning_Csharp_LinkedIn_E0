using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            //from line 11 to 14, will simulate the behaviour/event of video encoding being complete.
            var video = new Video() { VideoName = "Naruto_Anime" };
            var vidEncode = new VideoEncoder();
            vidEncode.Encode(video);
            Console.WriteLine("Video has been encoded successfully");
        }
    }
}
