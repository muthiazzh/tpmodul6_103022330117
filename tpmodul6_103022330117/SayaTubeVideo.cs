using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022330117
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Title cannot be null or empty");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999); 
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            if (count < 0)
                throw new ArgumentException("Play count cannot be negative");

            this.playCount += count;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}

