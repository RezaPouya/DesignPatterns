using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.StateMachine
{
    public class AudioPlayerUserInterface
    {
        protected AudioPlayer _audioPlayer;

        public AudioPlayerUserInterface(AudioPlayer audioPlayer)
        {
            _audioPlayer = audioPlayer;
        }

        public void ClickLockButton()
        {
            _audioPlayer.ClickLock();
        }

        public void ClickPlayButton()
        {
            _audioPlayer.ClickPlay();
        }

        public void ClickNextButton()
        {
            _audioPlayer.ClickNext();
        }

        public void ClickPreviousButton()
        {
            _audioPlayer.ClickPrevious();
        }
    }
}
