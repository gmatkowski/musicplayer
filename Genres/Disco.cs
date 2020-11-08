using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer.Genres
{
    class Disco: Country
    {
        public override string Play()
        {
            return String.Format("{0} {1}", base.Play(), "CcC");
        }

        public override string getName()
        {
            return "Disco";
        }
    }
}
