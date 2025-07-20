using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    internal class MediaPlayer
    {
        public void Play() { }
        public void Pause() { }
        public void Stop() { }

        private Lazy<AllTracks> _allSongs = 
            new Lazy<AllTracks>( () =>
            {
                Console.WriteLine("Creating AllTracks object!");
                return new AllTracks();
            });
        public AllTracks GetAllTracks()
        {
            return _allSongs.Value;
        }
    }
}
