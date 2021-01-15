namespace Behavioral.StateMachine.AudioPlayerStates
{
    public class AudioPlayerReadyState : AudioPlayerState
    {
        public AudioPlayerReadyState(AudioPlayer audioPlayer) : base(audioPlayer)
        { }

        public override void ClickLock()
        {
            _audioPlayer.ChangeState(new AudioPlayerLockedState(_audioPlayer));
        }

        public override void ClickNext()
        {
            _audioPlayer.NextSong();
        }

        public override void ClickPlay()
        {
            _audioPlayer.ChangeState(new AudioPlayerPlayingState(_audioPlayer));
            _audioPlayer.StartPlayback();
        }

        public override void ClickPrevious()
        {
            _audioPlayer.PreviousSong();
        }
    }
}