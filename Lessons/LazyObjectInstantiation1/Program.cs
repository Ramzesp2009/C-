using System;
using LazyObjectInstantiation;

namespace LazyObjectInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instantiation *****\n");
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.Play();
            MediaPlayer yourPlayer = new MediaPlayer();
            AllTracks yourMusic = yourPlayer.GetAllTracks();
            Console.ReadLine();
        }
    }
}