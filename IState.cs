using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    internal interface IState
    {
        IState PressPlay();
        IState PressAudioSource();
    }
}
