namespace Behavioral.StateMachine.AudioPlayerStates
{
    public class AudioPlayerPlayingState : AudioPlayerState
    {
        public AudioPlayerPlayingState(AudioPlayer audioPlayer) : base(audioPlayer)
        { }

        public override void ClickLock()
        {
            _audioPlayer.ChangeState(new AudioPlayerLockedState(_audioPlayer));
        }

        public override void ClickNext()
        {
            _audioPlayer.NextSong();

            //    if (event.doubleclick)
            //      player.nextSong()
            //    else
            //      player.fastForward(5)
        }

        public override void ClickPlay()
        {
            _audioPlayer.ChangeState(new AudioPlayerReadyState(_audioPlayer));
        }

        public override void ClickPrevious()
        {
            _audioPlayer.PreviousSong();

            //if (event.doubleclick)
            //    player.previous()
            //else
            //    player.rewind(5)
        }
    }
}