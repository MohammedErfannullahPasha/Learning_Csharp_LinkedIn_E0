﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        //This method simulates the behaviour of video encoding
        public void Encode(Video video)
        {
            Console.WriteLine("Video is being encoded.....Please wait");
            Thread.Sleep(4000);
        }
    }
}
