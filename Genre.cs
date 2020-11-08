using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer
{
    abstract class Genre
    {
        protected string GenreSound = "AaA";

        public virtual string Play()
        {
            return String.Format("{0}", GenreSound);
        }
        abstract public string GetName();
    }
}
