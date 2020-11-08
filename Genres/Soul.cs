using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer.Genres
{
    class Soul: Rap
    {
        public override string Play()
        {
            return String.Format("{0} {1}", base.Play(), "FfF");
        }

        public override string GetName()
        {
            return "Soul";
        }
    }
}
