using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    internal class Standby : IState
    {
        public IState PressAudioSource()
        {
            return new MP3Playing();
        }

        public IState PressPlay()
        {
            return null;
        }
    }
}
