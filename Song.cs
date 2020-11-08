using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer
{
    class Song
    {
        public Genre Genre { set; get; }
        public string Title { set; get; }
        public string Contractor { set; get; }

        public Song(Genre genre, string title, string contractor)
        {
            Genre = genre;
            Title = title;
            Contractor = contractor;
        }

        public string Play()
        {
            return String.Format("Tytuł {0}, Wykonawca {1}, Brzmienie: {2}", Title, Contractor, Genre.Play());
        }
    }
}
