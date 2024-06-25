﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    internal class MP3Paused : IState
    {
        public IState PressAudioSource()
        {
            return new Radio();
        }

        public IState PressPlay()
        {
            return new MP3Playing();
        }
    }
}
