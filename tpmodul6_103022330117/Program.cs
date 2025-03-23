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

        //tambahan di main utk menjelankan soal2
        for (int i = 0; i < 100; i++)
        {
            video.IncreasePlayCount(10000000);
        }
    }
}