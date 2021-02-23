using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCd: Product
    {
        public List<string> Tracks { get; } = new List<string>();
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }

        public MusicCd() { }

        public MusicCd(string artist, string title, decimal price, short released) : base(title, price)
        {
            Artist = artist;
            Released = released;
        }

        public void AddTrack(string track)
        {
            //List<string> listOfTracks = new List<string>();
            Tracks.Add(track);
            
        }
    }
}
