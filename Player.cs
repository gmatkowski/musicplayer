using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer
{
    class Player
    {
        public List<Song> songs = new List<Song>();

        public void Add(Song song)
        {
            songs.Add(song);
        }

        public void Remove(int index)
        {
            songs.RemoveAt(index);
        }

    }
}
