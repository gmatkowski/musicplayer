using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer.Genres
{
    class Pop: Disco
    {
        public override string Play()
        {
            return String.Format("{0} {1}", base.Play(), "DdD");
        }

        public override string GetName()
        {
            return "Pop";
        }
    }
}
