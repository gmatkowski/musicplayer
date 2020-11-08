using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer
{
    class Song
    {
        public Genre Genre { set; get; }
        public string Title { set; get; }
        public string Artist { set; get; }

        public Song(Genre genre, string title, string artist)
        {
            Genre = genre;
            Title = title;
            Artist = artist;
        }

        public string Play()
        {
            return String.Format("Tytuł {0}, Wykonawca {1}, Brzmienie: {2}", Title, Artist, Genre.Play());
        }
    }
}
