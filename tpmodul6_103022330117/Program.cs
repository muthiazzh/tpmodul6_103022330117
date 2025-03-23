using tpmodul6_103022330117;
using System;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muthi'ah Az Zahra");
        video.PrintVideoDetails();

        video.IncreasePlayCount(404);
        video.PrintVideoDetails();
    }
}