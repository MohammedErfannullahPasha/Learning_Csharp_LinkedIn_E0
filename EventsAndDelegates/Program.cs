using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() { VideoName = "Naruto_Anime" };
            
            var vidEncode = new VideoEncoder(); //publisher
            var mailService = new MailService(); //Subscriber
            var messageService = new MessageService(); //Subscriber

            //subsriber should subscribe/register the event before it begin or else, it will be null and user will face null exception.
            vidEncode.VideoEncoded += mailService.SubVideoEncodedMail;
            vidEncode.VideoEncoded += messageService.SubVideoEncodedMessage;
            
            vidEncode.Encode(video);

        }
    }
}
