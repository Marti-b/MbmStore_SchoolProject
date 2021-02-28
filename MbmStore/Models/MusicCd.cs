using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCd: Product
    {
        public List<Track> Tracks { get; } = new List<Track>();
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public MusicCd() { }

        public MusicCd(string artist, string title, decimal price, short released, string imageFileName) : base(title, price)
        {
            Artist = artist;
            Released = released;
            ImageFileName = imageFileName;
        }

        public void AddTrack(Track track)
        {
            //List<string> listOfTracks = new List<string>();
            Tracks.Add(track);
            
        }

        public TimeSpan GetPlayingTime()
        {
            
            TimeSpan result = new TimeSpan(0,0,0);
            foreach (var track in Tracks)
            {
                result += track.Length;
            }

            return result;
        }
    }
}
