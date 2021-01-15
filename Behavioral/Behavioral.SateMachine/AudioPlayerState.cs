using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.StateMachine
{
    public abstract class AudioPlayerState
    {
        protected AudioPlayer _audioPlayer;

        public AudioPlayerState(AudioPlayer audioPlayer)
        {
            _audioPlayer = audioPlayer;
        }

        public abstract void ClickLock();

        public abstract void ClickPlay();

        public abstract void ClickNext();

        public abstract void ClickPrevious();

       
    }
}
