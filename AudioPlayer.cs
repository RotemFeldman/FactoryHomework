using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    internal class AudioPlayer
    {
        public IState CurrentState { get; set; }


        public AudioPlayer(IState startState)
        {
            CurrentState = startState;
        }

        public void PressAudio()
        {
            var s = CurrentState.PressAudioSource();
            if (s != null)
            {
                CurrentState = CurrentState.PressAudioSource();
            }
        }

       public void PressPlay()
       {
            var s = CurrentState.PressPlay();
            if (s != null)
            {
                CurrentState = CurrentState.PressPlay();
            }
       }
    }
}
