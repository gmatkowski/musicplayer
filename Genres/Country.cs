using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer.Genres
{
    class Country: Genre
    {
        public override string Play()
        {
            return String.Format("{0} {1}", base.Play(), "BbB");
        }

        public override string getName()
        {
            return "Country";
        }
    }
}
