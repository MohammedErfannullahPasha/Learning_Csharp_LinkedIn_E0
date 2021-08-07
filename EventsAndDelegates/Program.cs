using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() { VideoName = "Naruto_Anime" };
            var vidEncode = new VideoEncoder();
            vidEncode.Encode(video);


            Console.WriteLine("Video has been encoded successfully");
        }
    }
}
