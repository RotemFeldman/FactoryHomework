using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    internal class Radio : IState
    {
        public IState PressAudioSource()
        {
            return null;
        }

        public IState PressPlay()
        {
            return new Standby();
        }
    }
}
