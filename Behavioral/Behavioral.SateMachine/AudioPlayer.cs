using Behavioral.StateMachine.AudioPlayerStates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Behavioral.StateMachine
{
    public class AudioPlayer
    {
        #region properties

        internal AudioPlayerState _state;

        private readonly AudioPlayerUserInterface _userInterface;

        public ushort Volume { get; private set; }

        public List<string> PlayList { get; private set; }

        public string CurrentSong { get; private set; }

        public bool IsPlaying { get; private set; }

        #endregion properties

        public AudioPlayer()
        {
            _state = new AudioPlayerReadyState(this);
            _userInterface = new AudioPlayerUserInterface(this);
        }

        public AudioPlayer(List<string> playList)
        {
            PlayList = playList;
            _state = new AudioPlayerReadyState(this);
            _userInterface = new AudioPlayerUserInterface(this);
        }

        public void ChangeState(AudioPlayerState state)
        {
            this._state = state;
        }

        public void ClickLock()
        {
            _state.ClickLock();
        }

        public void ClickNext()
        {
            _state.ClickNext();
        }

        public void ClickPlay()
        {
            _state.ClickPlay();
        }

        public void ClickPrevious()
        {
            _state.ClickPrevious();
        }

        //---------

        public void StartPlayback()
        {
            CheckSongAvailibility();
            if (string.IsNullOrEmpty(this.CurrentSong))
            {
                CurrentSong = this.PlayList.FirstOrDefault();
            }

            // play Current Song

            IsPlaying = true;
        }

        public void StopPlayback()
        {
            if (IsPlaying == true)
                IsPlaying = false;

            // stop current song and save its time
        }

        public void NextSong()
        {
            CheckSongAvailibility();

            if (string.IsNullOrEmpty(CurrentSong))
            {
                CurrentSong = this.PlayList.FirstOrDefault();
            }
            var currentSong = this.PlayList.FirstOrDefault(p => p.Equals(CurrentSong));
            var currentSongIndex = this.PlayList.IndexOf(currentSong);
            var nextSong = this.PlayList.ElementAtOrDefault(currentSongIndex + 1);

            this.CurrentSong = nextSong ?? this.PlayList.FirstOrDefault();

            if (IsPlaying)
            {
                // play currentSong
            }
        }

        public void PreviousSong()
        {
            CheckSongAvailibility();

            if (string.IsNullOrEmpty(CurrentSong))
            {
                CurrentSong = this.PlayList.FirstOrDefault();
            }

            var currentSong = this.PlayList.FirstOrDefault(p => p.Equals(CurrentSong));
            var currentSongIndex = this.PlayList.IndexOf(currentSong);
            var previousSong = this.PlayList.ElementAtOrDefault(currentSongIndex - 1);

            this.CurrentSong = previousSong ?? this.PlayList.FirstOrDefault();

            if (IsPlaying)
            {
                // play currentSong
            }
        }

        public void FastForward(long time)
        {
            throw new NotImplementedException();
        }

        protected void RewindState()
        {
            throw new NotImplementedException();
        }

        protected void CheckSongAvailibility()
        {
            if (this.PlayList == null || this.PlayList.Count == 0)
                throw new Exception("هیچ آهنگی در لیست پخش نیست");
        }
    }
}