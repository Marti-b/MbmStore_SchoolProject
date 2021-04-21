using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD: Product
    {
        public List<Track> Tracks { get; } = new List<Track>();
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public MusicCD() { }

        public MusicCD(string artist, string title, decimal price, short released, string imageUrl, int productID) : base(productID,title, price)
        {
            
            Artist = artist;
            Released = released;
            ImageUrl = imageUrl;
        }

        public void AddTrack(Track track)
        {
            
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
