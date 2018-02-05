using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPictures = int.Parse(Console.ReadLine());
            int filterTimeInSecPerPicture = int.Parse(Console.ReadLine());
            byte filterFactor = byte.Parse(Console.ReadLine());
            int uploadTimeInSecPerPicture = int.Parse(Console.ReadLine());

            long filterTimeInSecTotal = (long)numberOfPictures * filterTimeInSecPerPicture;
            long uploadTimeInSecTotal = (long)Math.Ceiling((double)numberOfPictures * ((double)(filterFactor)
                    / 100)) * uploadTimeInSecPerPicture;
            long totalTimeInSec = filterTimeInSecTotal + uploadTimeInSecTotal;

            //-byte seconds = (byte)(((double)totalTimeInSec / 60 - Math.Floor((double)totalTimeInSec / 60)) 
            //-      * 60);
            //-byte minutes = (byte)(((double)totalTimeInSec / (60 * 60) - 
            //-      Math.Floor((double)totalTimeInSec / (60 * 60))) * 60);
            //-byte hours = (byte)(((double)totalTimeInSec / (24 * 60 * 60) -
            //-     Math.Floor((double)totalTimeInSec / (24 * 60 * 60))) * 24);
            //-byte days = (byte)(Math.Floor((double)totalTimeInSec / (24 * 60 * 60)));
            //Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");

            TimeSpan time = TimeSpan.FromSeconds(totalTimeInSec);
            string timeResult = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                time.Days,
                time.Hours,
                time.Minutes,
                time.Seconds);
            Console.WriteLine(timeResult);
        }
    }
}
