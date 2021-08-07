using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        //Let us create an event : when the video is encoded the notification is triggered and anyone with interest can subscribe it.
        //To publish an event, it is a 3 step process :

        //1 - define a delegate : it acts as agreement between publisher and subscriber. this determines/defines the signature of 
        //event handling method in subscriber. this will be called when event is trggered i.e., when video is encoded.
        //2 - define an event based on delegate
        //3 - raise or publish the event

        //step 1
        public delegate void VideoEncoderEventHandler(object Source, EventArgs args);

        //step 2 (event name should be past tense as if the event is completed)
        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Video is being encoded.....Please wait");
            Thread.Sleep(4000);
            Console.WriteLine("Video is Encoded successfully");
            //step 3 : Raise the event : this method with inform all the subscribers
            onVideoEncoded();
        }

        //To raise an event we method which should be responsible. Below is the standard syntax for method to bb created for event
        //It is called as Event publisher method. name should begin with on_______
        protected virtual void onVideoEncoded()
        {
            //raise the event after verifying not null
            if (VideoEncoded != null)
            {
                //source of the event is current class, hence used "this"
                VideoEncoded(this, EventArgs.Empty);
            }

        }

    }
}
