using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer.Genres
{
    class Rap: Pop
    {
        public override string Play()
        {
            return String.Format("{0} {1}", base.Play(), "EeE");
        }

        public override string getName()
        {
            return "Rap";
        }
    }
}
